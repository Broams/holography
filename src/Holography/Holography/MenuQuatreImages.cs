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
    public partial class MenuQuatreImages : Form
    {
        public Driver driver;
        public MenuQuatreImages(Driver driv)
        {
            driver = driv;
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();

        private void BouttonImage1_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxImage1.Text = ofd.FileName;
            }
        }

        private void BouttonImage2_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxImage2.Text = ofd.FileName;
            }
        }

        private void BouttonImage3_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxImage3.Text = ofd.FileName;
            }
        }

        private void BouttonImage4_Click(object sender, EventArgs e)
        {
            ofd.Filter = "JPEG|*.jpeg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBoxImage4.Text = ofd.FileName;
            }
        }

        private void BouttonDemarrer_Click(object sender, EventArgs e)
        {
            if ( !String.IsNullOrEmpty(TextBoxImage1.Text) && !String.IsNullOrEmpty(TextBoxImage2.Text) && !String.IsNullOrEmpty(TextBoxImage3.Text) && !String.IsNullOrEmpty(TextBoxImage4.Text) && !String.IsNullOrEmpty(textBoxTailleEcran.Text))
            {
                driver.createRender(int.Parse(textBoxTailleEcran.Text), TextBoxImage1.Text, TextBoxImage2.Text, TextBoxImage3.Text, TextBoxImage4.Text);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Il manque des informations.");
            }
        }
    }
}
