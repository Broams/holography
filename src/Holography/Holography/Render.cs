using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holography
{
    public class Render
    {
        public Hologram1 holo;
        public Hologram2 holo2;
        public Driver driver;
        public Render(string image, int size, Driver driv)
        {
            this.driver = driv;
            driver.mode = 0;
            virtualScreen vs = new virtualScreen(image);
            holo = new Hologram1(vs, size);
        }
        public Render(int size, string video, Driver driv)
        {
            this.driver = driv;
            driver.mode = 1;
            holo2 = new Hologram2(video, size);
        }
        public Render(int size, string image1, string image2, string image3, string image4, Driver driv)
        {
            this.driver = driv;
            driver.mode = 2;
        }
       
        public void SetVirtualScreen(int id, virtualScreen virtualscreen)
        {

        }
        
        public void SetRender()
        {

        }

        public void SetRotation(float radian)
        {

        }
    }
}