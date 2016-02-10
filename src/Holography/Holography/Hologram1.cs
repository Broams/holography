using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holography
{
    public class Hologram1 : Hologram
    {
        private Image north;
        private Image east;
        private Image south;
        private Image west;
        private virtualScreen vs;
        private HologramDisplay1 holoDisplay;
        private int size;
        public Hologram1(virtualScreen vs, int size)
        {
            this.vs = vs;
            this.size = size;
        }

        public void LancerHologram1()
        {
            process();
            holoDisplay = new HologramDisplay1(this);
            holoDisplay.Size = new Size(size, size);

            int largeur = (holoDisplay.Width - 16); // on enleve les bordures (2 * 8)
            int hauteur = (holoDisplay.Height - 39); // on eneleve la bordure en bas et la barre de titre (31 + 9)

            holoDisplay.pictureBox1.Height = hauteur / 3;
            holoDisplay.pictureBox1.Width = largeur / 3;
            holoDisplay.pictureBox1.Location = new Point(largeur / 3, 0);

            holoDisplay.pictureBox2.Height = hauteur / 3;
            holoDisplay.pictureBox2.Width = largeur / 3;
            holoDisplay.pictureBox2.Location = new Point(largeur * 2 / 3, hauteur / 3);

            holoDisplay.pictureBox3.Height = hauteur / 3;
            holoDisplay.pictureBox3.Width = largeur / 3;
            holoDisplay.pictureBox3.Location = new Point(largeur / 3, hauteur * 2 / 3);

            System.Windows.Forms.MessageBox.Show("Largeur : " + largeur + "\n Largeur picture3: " + holoDisplay.pictureBox3.Width + "\n Hauteur : " + hauteur + "\n Hauteur picture3 : " + holoDisplay.pictureBox3.Height);

            holoDisplay.pictureBox4.Height = hauteur / 3;
            holoDisplay.pictureBox4.Width = largeur / 3;
            holoDisplay.pictureBox4.Location = new Point(0, hauteur / 3);

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
