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
    public partial class QLDONHANG : Form
    {
        public QLDONHANG()
        {
            InitializeComponent();
        }

        private void BTN_THEM_Click(object sender, EventArgs e)
        {
            AddOrder f = new AddOrder();
            f.ShowDialog();
        }
    }
}
