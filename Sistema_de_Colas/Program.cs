using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Colas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSplash());
            //Application.Run(new frmMM1());
            //Application.Run(new frmMG1());
            //Application.Run(new frmMD1());
            //Application.Run(new frmMEk1());
        }
    }
}
