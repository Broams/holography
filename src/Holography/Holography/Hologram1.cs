using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holography
{
    public class Hologram1 : Hologram
    {
        private Image north;
        private Image east;
        private Image south;
        private Image west;
        private virtualScreen vs;
        private HologramDisplay holoDisplay;
        private int size;
        public Hologram1(virtualScreen vs, int size)
        {
            this.vs = vs;
            this.size = size;
        }

        public void LancerHologram1()
        {
            process();
            holoDisplay = new HologramDisplay(this);
            holoDisplay.Size = new System.Drawing.Size(size, size);
            holoDisplay.ShowDialog();
        }
        public void process()
        {
            north = vs.getImage();
            east = vs.getImage();
            south = vs.getImage();
            west = vs.getImage();
        }

        public Image getNorth()
        {
            return north;
        }
        public Image getEast()
        {
            return east;
        }
        public Image getSouth()
        {
            return south;
        }

        public Image getWest()
        {
            return west;
        }

        public string getPath()
        {
            return vs.getPath();
        }
    }
}
