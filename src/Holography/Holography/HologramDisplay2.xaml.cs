using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Holography
{
    /// <summary>
    /// Logique d'interaction pour HologramVideo.xaml
    /// </summary>
    public partial class HologramDisplay2 : Window
    {
        class Test
        {
            public string TestID { get; set; }
        }
        public HologramDisplay2(Hologram2 holo)
        {
            InitializeComponent();
            Test testInstance = new Test();
            testInstance.TestID = holo.video;
            this.DataContext = testInstance;
            myMediaElement1.LoadedBehavior = MediaState.Manual;
            myMediaElement1.Play();
        }
    }
}