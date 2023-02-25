using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStore.GUI
{
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_EMPLOYEE_Click(object sender, EventArgs e)
        {
            GUI.DetailEmPloyee frmThem = new DetailEmPloyee();
            frmThem.ShowDialog();
        }

        private void BTN_CLIENT_Click(object sender, EventArgs e)
        {

        }

        private void BTN_PRODUCT_Click(object sender, EventArgs e)
        {

        }
    }
}
