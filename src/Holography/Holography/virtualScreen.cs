using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holography
{
    public class virtualScreen : IDisposable
    {
        private Image image;
        private string path;

        public virtualScreen(string url)
        {
            this.path = url;
            image = Image.FromFile(url);
        }

        public Image getImage()
        {
            return image;
        }

        public string getPath()
        {
            return path;
        }

        public void Dispose()
        {
            this.Dispose();
        }
    }
}
