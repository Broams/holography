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
    public partial class MenuImage : Form
    {
        public Driver driver;
        public MenuImage(Driver driv)
        {
            driver = driv;
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void SelectionImage_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG|*.jpeg";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                FileName.Text = ofd.FileName;
                SafeFileName.Text = ofd.SafeFileName;
            }
        }

        private void BouttonDemarrer_Click(object sender, EventArgs e)
        {
            if ( !String.IsNullOrEmpty(SafeFileName.Text) && !String.IsNullOrEmpty(textBoxTailleEcran.Text) )
            {
                driver.createRender(ofd.FileName, int.Parse(textBoxTailleEcran.Text));
                this.Dispose(true);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Il manque des informations.");
            }
        }

        private void MenuImage_Load(object sender, EventArgs e)
        {

        }
    }
}
