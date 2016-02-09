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
    public partial class MenuPrincipal : Form
    {
        public Driver driver;
        public MenuPrincipal(Driver driv)
        {
            driver = driv;
            InitializeComponent();
            comboBoxMode.Items.Add("Menu une image");
            comboBoxMode.Items.Add("Menu Video");
            comboBoxMode.Items.Add("Menu quatre images");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxMode.SelectedIndex == 0)
            {
                MenuImage menuImage = new MenuImage(driver);
                this.Hide();
                menuImage.ShowDialog();
            }
            else if (comboBoxMode.SelectedIndex == 1)
            {
                MenuVideo menuVideo = new MenuVideo(driver);
                this.Hide();
                menuVideo.ShowDialog();
            }
            else if (comboBoxMode.SelectedIndex == 2)
            {
                MenuQuatreImages menuQuatreImage = new MenuQuatreImages(driver);
                this.Hide();
                menuQuatreImage.ShowDialog();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Combobox vide");
            }
        }
    }
}
