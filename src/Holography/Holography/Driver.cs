using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if(render != null)
            {
                if( mode == 0 )
                {
                    render.holo.process();
                }
                else if( mode == 1 )
                {
                    render.holo2.process();
                }
                else if( mode == 2 )
                {

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Aucun mode n'a été detecté.");

                }
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
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
