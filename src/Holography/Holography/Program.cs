using System;
using System.Collections.Generic;
using System.IO;
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
            if (verifExecute())
            {
                driver.run();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("La machine ne dispose pas des ressources suffisantes afin d'executer l'application");
            }
        }
        private static bool verifExecute()
        {
            if (File.Exists("LogFile.txt"))
            {
                string lastLine = File.ReadLines("Logfile.txt").Last();
                string lastChar = lastLine.Substring(lastLine.Length - 4);

                if (Convert.ToInt32(lastChar) > 2000)
                    return true;
                else return false;
            }
            else return true;
        }
    }
}
