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
        private Render render;
        private Kinect kinect;

        public void run()
        {
            windowsForm = new MenuPrincipal(this);
            windowsForm.ShowDialog();
            
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
