using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStore.BUS;

namespace PiStore
{
    public partial class Login : Form
    {
        private BUS_Login bus_Login;
        public Login()
        {
            InitializeComponent();
            bus_Login = new BUS_Login();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HD_USERNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            String username = HD_USERNAME.Text;
            String password = HD_PASSWORD.Text;

            if(bus_Login.checkLogin(username, password) == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");
                Form1 f = new Form1();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nhập sai thông tin đăng nhập!");
            }
        }
    }
}
