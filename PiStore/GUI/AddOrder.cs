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
using PiStore.DAL;
using PiStore.DTO;

namespace PiStore.GUI
{
    public partial class AddOrder : Form
    {
        private DAL_Orders dal_Orders;
        private BUS_Orders bus_Orders;
        private BUS_Client bus_Client;
        private BUS_Employee bus_Employee;
        private DTO_Orders dto_Orders;
        private int clientID;
        private int employeeID;
        public AddOrder()
        {
            InitializeComponent();
            loadData();
        }


        public void loadData()
        {
            dal_Orders = new DAL_Orders();
            bus_Orders = new BUS_Orders();
            dto_Orders = new DTO_Orders();
            bus_Client = new BUS_Client();
            bus_Employee = new BUS_Employee();
    
            DataTable dt = new DataTable();

            dt = bus_Client.getAllClient();
            CB_KHACHHANG.DataSource = dt;
            CB_KHACHHANG.DisplayMember = "Name";
            CB_KHACHHANG.ValueMember = "ID";

            dt = bus_Employee.getAllEmployee();
            CB_NHANVIEN.DataSource = dt;
            CB_NHANVIEN.DisplayMember = "Name";
            CB_NHANVIEN.ValueMember = "ID";


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

        private void CB_KHACHHANG_SelectedIndexChanged(object sender, EventArgs e)
        {

            String ID = CB_KHACHHANG.SelectedValue.ToString();
            if (ID != null && ID != "System.Data.DataRowView") {
                Int32.TryParse(ID, out int numValue);
                DataTable dt = bus_Client.getClientByID(numValue);
                var rowResult = dt.Rows[0];

                HD_PHONE.Text = rowResult.Field<String>("Phone");
                HD_ADDRESS.Text = rowResult.Field<String>("Address");

                clientID = numValue;
            }
        }

        private void CB_KHACHHANG_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_NEXT_Click(object sender, EventArgs e)
        {
            if (clientID == 0 || employeeID == 0)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin");
            }
            else
            {
                dto_Orders.ClientID = clientID;
                dto_Orders.EmployeeID = employeeID;
                dto_Orders.OrderDate = DateTime.Now;
                dto_Orders.TotalPrice = 0;

                bus_Orders.insertOrders(dto_Orders);
                this.Hide();

                AddOrderItem f = new AddOrderItem();
                f.ShowDialog();
            }
        }

        private void CB_NHANVIEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ID = CB_NHANVIEN.SelectedValue.ToString();
            if (ID != null && ID != "System.Data.DataRowView")
            {
                Int32.TryParse(ID, out int numValue);

                employeeID = numValue;
            }

        }
    }
}
