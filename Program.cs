using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLDWinForm
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
              Application.Run(new FormLogin());
            // Application.Run(new FormShowAllUsers());
            //  Application.Run(new FormShowAllPeople());
             // Application.Run(new Form1());
        }
    }
}
