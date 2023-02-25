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
    public partial class AddOrderItem : Form
    {
        public AddOrderItem()
        {
            InitializeComponent();
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát quá trình tạo đơn đặt hàng?",
                      "Thông báo hủy", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    this.Close();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
