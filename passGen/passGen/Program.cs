using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace passGen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            /*
            using (var mgr = new UpdateManager("https://github.com/TermiSenpai/PasswordGenerator/releases/latest"))
                await mgr.UpdateApp(); */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
