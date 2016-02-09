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
        public Render(string image, int size)
        {
            virtualScreen vs = new virtualScreen(image);
            holo = new Hologram1(vs, size);
        }
        public Render(int size, string video)
        {

        }
        public Render(int size, string image1, string image2, string image3, string image4)
        {

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