using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holography
{
    public partial class HologramDisplay : Form
    {
        private Hologram1 holo;
        public HologramDisplay(Hologram1 holo)
        {
            this.holo = holo;
            InitializeComponent();
            pictureBox1.Image = holo.getNorth();
            pictureBox2.Image = rotateImage(holo.getEast(), 90);
            pictureBox3.Image = rotateImage(holo.getSouth(), 180);
            pictureBox4.Image = rotateImage(holo.getWest(), 270);
        }

        public Image rotateImage(Image img, int angle)
        {
            
            var bmp = new Bitmap(img);

            using (Graphics gfx = Graphics.FromImage(bmp))
            {
                gfx.Clear(Color.White);
                gfx.DrawImage(img, 0, 0, img.Width, img.Height);
            }

            if(angle == 90)
            {
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else if(angle == 180 )
            {
                bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            else if (angle == 270)
            {
                bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }

            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
