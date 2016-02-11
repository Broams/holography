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
    public partial class MenuVideo : Form
    {
        public Driver driver;
        public MenuVideo(Driver driv)
        {
            driver = driv;
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void SelectionVideo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "MP4, WMV|*.mp4;*.wmv";
            if ( ofd.ShowDialog() == DialogResult.OK )
            {
                FileName.Text = ofd.FileName;
                SafeFileName.Text = ofd.SafeFileName;
            }
        }


        private void BouttonDemarrer_Click(object sender, EventArgs e)
        {
            if ( !String.IsNullOrEmpty(SafeFileName.Text) && !String.IsNullOrEmpty(textBoxTailleEcran.Text))
            {
                driver.createRender(int.Parse(textBoxTailleEcran.Text), ofd.FileName, Desynchronise.Checked);
                this.Dispose();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("La vidéo ou la taille n'a pas été trouvé");
            }
        }

        private void MenuVideo_Load(object sender, EventArgs e){}

    }
}
