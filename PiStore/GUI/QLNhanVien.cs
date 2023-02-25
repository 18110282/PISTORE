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
using PiStore.GUI;

namespace PiStore.GUI
{
    public partial class QLNhanVien : Form
    {
        private BUS_Employee bus_Employee;

        private int codeOfSelectedRow;
        public QLNhanVien()
        {
            InitializeComponent();
            bus_Employee = new BUS_Employee();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_EMPLOYEE_Click(object sender, EventArgs e)
        {
            DetailEmPloyee frmThem = new DetailEmPloyee();
            frmThem.ShowDialog();
            loadData();
        }

        private void BTN_CLIENT_Click(object sender, EventArgs e)
        {
            DetailEmPloyee frmThem = new DetailEmPloyee(codeOfSelectedRow);
            frmThem.ShowDialog();
            loadData();
        }

        private void BTN_PRODUCT_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_Employee.deleteEmployee(codeOfSelectedRow))
                {
                    MessageBox.Show("Xóa thành công");
                    loadData();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi, không thể xóa");
            }
        }

        public void loadData()
        {
            DataTable dt = bus_Employee.getAllEmployee();
            DGV_NHANVIEN.DataSource = dt;
            BTN_CLIENT.Enabled = false;
            BTN_PRODUCT.Enabled = false;
        }

        private void DGV_NHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void DGV_NHANVIEN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
            object value  = DGV_NHANVIEN.Rows[e.RowIndex].Cells[0].Value;
            if(value != DBNull.Value)
            {
                codeOfSelectedRow = Convert.ToInt32(value);
                BTN_CLIENT.Enabled = true;
                BTN_PRODUCT.Enabled = true;
            }
            else
            {
                BTN_CLIENT.Enabled = false;
                BTN_PRODUCT.Enabled = false;
            }
        }
    }
}
