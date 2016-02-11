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
        public int mode = 0;

        public void run()
        {
            windowsForm = new MenuPrincipal(this);
            windowsForm.ShowDialog();

            if (render != null)
            {
                if (mode == 0)
                {
                    render.holo.process();
                }
                else if (mode == 1)
                {
                    kinect = Kinect.getInstance();
                    Thread KinectThread = new Thread(new ThreadStart(kinect.LancerKinect));
                    KinectThread.Start();

                    //Thread Holo2Thread = new Thread(new ThreadStart(render.holo2.process));
                    //Holo2Thread.SetApartmentState(ApartmentState.STA);
                    //Holo2Thread.Start();

                    Thread BoucleWhileThread = new Thread(new ThreadStart
                        (delegate () 
                        {
                            while (true)
                            {
                                if (kinect.getState() == 1)
                                {
                                    render.holo2.holoDisplay.ChangerStateVideo();
                                }
                                Thread.Sleep(200);
                            }
                        }));
                    BoucleWhileThread.Start();
                    
                    render.holo2.process();

                    /*while (true)
                    {
                        //System.Windows.Forms.MessageBox.Show(kinect.getState().ToString());
                        
                        if(kinect.getState() == 1){
                            render.holo2.holoDisplay.ChangerStateVideo();
                        }
                        Thread.Sleep(200);
                    }*/

                }
                else if (mode == 2)
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
        public void createRender(int size, string video) // pour une video
        {
            render = new Render(size, video, this);
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