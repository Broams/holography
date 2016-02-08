using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holography
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MenuPrincipal menuPP = new MenuPrincipal();
            menuPP.ShowDialog();
        }
    }
}
