using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiStore.DTO;
using PiStore.DAL;
using PiStore.BUS;

namespace PiStore.GUI
{
    public partial class DetailEmPloyee : Form
    {
        Boolean MODE_INS;
        private DAL_Employee dal_Employee;
        private DTO_Employee dto_Employee;
        private BUS_Employee bus_Employee;

        public DetailEmPloyee()
        {
            InitializeComponent();
            MODE_INS = true;
            HD_SALARY.Text = "0";
            LBL_HEADER.Text = "Thêm Thông Tin Nhân Viên";
            loadData();
        }

    
        public DetailEmPloyee(int EMPLOYEEID)
        {
            InitializeComponent();
            MODE_INS = false;
            HD_ID.Text = EMPLOYEEID.ToString();
            LBL_HEADER.Text = "Sửa Thông Tin Nhân Viên";
            loadData();
            loadEmployeeByID(EMPLOYEEID);
        }

        public void loadData()
        {
            dal_Employee = new DAL_Employee();
            dto_Employee = new DTO_Employee();
            bus_Employee = new BUS_Employee();
        }

        public void loadEmployeeByID(int ID)
        {
            DataTable dt = new DataTable();
            dt = bus_Employee.getEmployeeByID(ID);
            var rowResult = dt.Rows[0];

            HD_NAME.Text = rowResult.Field<String>("Name");
            HD_EMAIL.Text = rowResult.Field<String>("Email");
            HD_PHONE.Text = rowResult.Field<String>("Phone");
            HD_ADDRESS.Text = rowResult.Field<String>("Address");
            HD_SALARY.Text = rowResult.Field<int>("Salary").ToString();
            DT_HIREDATE.Value = rowResult.Field<DateTime>("HireDate");
        }
        private void BTN_EMPLOYEE_Click(object sender, EventArgs e)
        {
            if (HD_NAME.Text == "" || HD_EMAIL.Text == "" || HD_PHONE.Text == "" || HD_ADDRESS.Text == "" || HD_SALARY.Text == "" )
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin!");
            }
            else if (KiemTraSoNhapVao(HD_PHONE.Text) == false | HD_PHONE.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
            }
            else if (CheckEmail(HD_EMAIL.Text)) 
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng kiểm tra lại");
            }
            else if (KiemTraSoNhapVao(HD_SALARY.Text) == false | Convert.ToInt32(HD_SALARY.Text) < 1000000)
            {
                MessageBox.Show("Tiền lương nhân viên không hợp lệ. Vui lòng kiểm tra lại");
            }
            else if (DT_HIREDATE.Value <= DateTime.Now && MODE_INS == true)
            {
                MessageBox.Show("Ngày thuê nhân viên không hợp lệ. Vui lòng kiểm tra lại");
            }
            else
            {
                dto_Employee.Name = HD_NAME.Text;
                dto_Employee.Email = HD_EMAIL.Text;
                dto_Employee.Phone = HD_PHONE.Text;
                dto_Employee.Address = HD_ADDRESS.Text;
                dto_Employee.Salary = Convert.ToInt32(HD_SALARY.Text);
                dto_Employee.HireDate = DT_HIREDATE.Value;

                if (MODE_INS == true)
                {

                    bus_Employee.insertEmployee(dto_Employee);
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    dto_Employee.ID1 = Convert.ToInt32(HD_ID.Text);
                    bus_Employee.updateEmployee(dto_Employee);
                    MessageBox.Show("Sửa thành công");
                    this.Close();
                }
            }    
        }
        private bool KiemTraSoNhapVao(string a)
        {
            foreach (char c in a)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        private bool CheckEmail(string a)
        {
            String pattern = @"(([^\s.]+)@((.[^\s]+)(\..[^\s]+)))";

            Regex rx = new Regex(pattern);

            // Tìm kiếm.
            MatchCollection matches = rx.Matches(a);

            if (matches.Count > 0)
                return false;
            else
                return true;
        }


        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            HD_NAME.Text        = "";
            HD_EMAIL.Text       = "";
            HD_PHONE.Text       = "";
            HD_ADDRESS.Text     = "";
            HD_SALARY.Text      = "0";
            DT_HIREDATE.Text    = DateTime.Now.ToString();
            DT_HIREDATE.Value   = DateTime.Now;
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Thông tin chưa được lưu. Bạn có chắc muốn thoát?",
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
