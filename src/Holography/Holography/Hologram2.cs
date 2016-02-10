using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Holography
{
    public class Hologram2 : Hologram
    {
        private HologramDisplay2 holoDisplay;
        public string video;
        public int size;

        public Hologram2(string video, int size)
        {
            this.video = video;
            this.size = size;
        }

        public void process()
        {
            holoDisplay = new HologramDisplay2(this);
            holoDisplay.Height = size;
            holoDisplay.Width = size;

            int largeur = Convert.ToInt32(holoDisplay.Width) - 16; // on enleve les bordures (2 * 8)
            int hauteur = Convert.ToInt32(holoDisplay.Height) - 39; // on eneleve la bordure en bas et la barre de titre (31 + 9)

            holoDisplay.myMediaElement1.Height = hauteur / 3;
            holoDisplay.myMediaElement1.Width = largeur / 3;

            holoDisplay.myMediaElement2.Height = hauteur / 3;
            holoDisplay.myMediaElement2.Width = largeur / 3;
            holoDisplay.myMediaElement2.IsMuted = true;

            holoDisplay.myMediaElement3.Height = hauteur / 3;
            holoDisplay.myMediaElement3.Width = largeur / 3;
            holoDisplay.myMediaElement3.IsMuted = true;

            holoDisplay.myMediaElement4.Height = hauteur / 3;
            holoDisplay.myMediaElement4.Width = largeur / 3;
            holoDisplay.myMediaElement4.IsMuted = true;

            holoDisplay.ShowDialog();
        }
    }
}
