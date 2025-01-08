using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static (double, double, double) TempConv(double temp, int index)
        {
            double c, f, k;
            c = f = k = 0;

            switch (index)
            {
                case 0:
                    c = temp;
                    f = (c * 9.0 / 5.0) + 32;
                    k = c + 273.15;
                    break;

                case 1:
                    f = temp;
                    c = (f - 32) * (5.0 / 9.0);
                    k = c + 273.15;
                    break;

                case 2:
                    k = temp;
                    c = k - 273.15;
                    f = (9.0 / 5.0) * c + 32;
                    break;
            }

            return (c, f, k);
        }
    }
}
