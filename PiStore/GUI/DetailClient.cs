﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiStore.GUI
{
    public partial class DetailClient : Form
    {
        Boolean MODE_INS;

        public DetailClient()
        {
            InitializeComponent();
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

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            HD_NAME.Text = "";
            HD_EMAIL.Text = "";
            HD_PHONE.Text = "";
            HD_ADDRESS.Text = "";
        }

        private void BTN_EMPLOYEE_Click(object sender, EventArgs e)
        {
            if (HD_NAME.Text == "" || HD_EMAIL.Text == "" || HD_PHONE.Text == "" || HD_ADDRESS.Text == "" )
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
            else
            {
                if (MODE_INS == true)
                {
                    // Tiến hành thực hiện insert
                }
                else
                {
                    //Tiến hành Update
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
    }
}
