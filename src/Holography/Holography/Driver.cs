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
        private int mode = 0;

        public void run()
        {
            windowsForm = new MenuPrincipal(this);
            windowsForm.ShowDialog();

            if(render != null)
            {
                if( mode == 0 )
                {
                    render.holo.LancerHologram1();
                }
                else if( mode == 1 )
                {

                }
                else if( mode == 2 )
                {

                }
                else { }
            }
        }

        public void createRender(string image, int size) // pour une image seule
        {
            render = new Render(image, size);
        }
        public void createRender(int size, string video) // pour une video
        {
            render = new Render(size, video);
        }
        public void createRender(int size, string image1, string image2, string image3, string image4) // pour les quatres images
        {
            render = new Render(size, image1, image2, image3, image4);
        }
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
