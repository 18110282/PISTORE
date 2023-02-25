using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStore.DAL;

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
            Application.Run(new GUI.AddOrder());
            //Application.Run(new GUI.QLNhanVien());
            DAL_DBConnection dal = new DAL_DBConnection();

        }
    }
}
