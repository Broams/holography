using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KinectFinal;
using System.Threading;

namespace Holography
{
    public class Driver : IDisposable
    {
        private MenuPrincipal windowsForm;
        private Render render = null;
        private Kinect kinect;
        public int mode;

        public void run()
        {
            windowsForm = new MenuPrincipal(this);
            windowsForm.ShowDialog();

            if (render != null)
            {
                if (mode == 0) // pour une image
                {
                    render.holo.process();
                }
                else if (mode == 1) // pour une vidéo
                {
                    kinect = Kinect.getInstance();
                    Thread KinectThread = new Thread(new ThreadStart(kinect.LancerKinect));
                    KinectThread.Start();

                    Thread Holo2Thread = new Thread(new ThreadStart(render.holo2.process));
                    Holo2Thread.SetApartmentState(ApartmentState.STA);
                    Holo2Thread.Start();
                    
                    int sta = 0;
                    Action action = delegate { render.holo2.holoDisplay.ChangerStateVideo(sta);};
                    while (true)
                    {
                        Thread.Sleep(50);
                        if (kinect.getState() == 1) // les deux mains sont proches du torse, c'est pour mettre en pause
                        {
                            sta = 1;
                            render.holo2.holoDisplay.myMediaElement1.Dispatcher.Invoke(action);
                        }
                        else if (kinect.getState() != 1 &&  render.holo2.holoDisplay != null) // si c'est différent de pause, alors il replay
                        {
                            sta = 0;
                            render.holo2.holoDisplay.myMediaElement1.Dispatcher.Invoke(action);
                        }
                        else { }
                    }
                }
                else if (mode == 2) // pour le cube en 3D
                {
                    kinect = Kinect.getInstance();
                    Thread KinectThread = new Thread(new ThreadStart(kinect.LancerKinect));
                    KinectThread.Start();

                    while (true)
                    {
                        System.Windows.Forms.MessageBox.Show(kinect.getState().ToString());
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Aucun mode n'a été detecté.");
                }
                this.Dispose();
            }
        }

        public void createRender(string image, int size) // pour une image seule
        {
            render = new Render(image, size, this);
        }
        public void createRender(int size, string video, bool check) // pour une video
        {
            render = new Render(size, video, check, this);
        }
        public void createRender(int size, string image1, string image2, string image3, string image4) // pour les quatres images
        {
            render = new Render(size, image1, image2, image3, image4, this);
        }
        public virtual void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}