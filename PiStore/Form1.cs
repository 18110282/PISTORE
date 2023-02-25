using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStore.GUI;

namespace PiStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LBL_TIME.Text = DateTime.Now.ToString("hh:mm:ss ");
            LBL_DATE.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void BTN_EMPLOYEE_Click(object sender, EventArgs e)
        {
            GUI.QLNhanVien frmNV = new GUI.QLNhanVien();
            frmNV.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_CLIENT_Click(object sender, EventArgs e)
        {
            QLKhachHang f = new QLKhachHang();
            f.ShowDialog();
        }
    }
}
