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
            Driver driver = new Driver();
            driver.run();
        }
    }
}
