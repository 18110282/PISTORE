using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStore.DAL;
using PiStore.GUI;

namespace PiStore
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
            //Application.Run(new Login());
            Application.Run(new QLDONHANG());
            //Application.Run(new GUI.QLNhanVien());
            //DAL_DBConnection dal = new DAL_DBConnection();

        }
    }
}
