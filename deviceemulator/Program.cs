using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deviceemulator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            System.Net.ServicePointManager.DefaultConnectionLimit = 10000;

            var splash = new ui.splash();
            splash.Show();
            splash.TopMost = true;

            Application.Run(new main());
        }
    }
}
