using System;
using System.Windows.Forms;

namespace TheMediaEditor
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

            // Initiate application by instantiating Controller:
            var Controller = new Controller();
        }
    }
}