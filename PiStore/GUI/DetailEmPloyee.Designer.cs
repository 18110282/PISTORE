
namespace PiStore.GUI
{
    partial class DetailEmPloyee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_HEADER = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HD_NAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HD_EMAIL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HD_PHONE = new System.Windows.Forms.TextBox();
            this.HD_ADDRESS = new System.Windows.Forms.TextBox();
            this.HD_SALARY = new System.Windows.Forms.TextBox();
            this.DT_HIREDATE = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_EMPLOYEE = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.HD_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_HEADER
            // 
            this.LBL_HEADER.AutoSize = true;
            this.LBL_HEADER.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HEADER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_HEADER.Location = new System.Drawing.Point(11, 9);
            this.LBL_HEADER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_HEADER.Name = "LBL_HEADER";
            this.LBL_HEADER.Size = new System.Drawing.Size(394, 41);
            this.LBL_HEADER.TabIndex = 27;
            this.LBL_HEADER.Text = "Thêm / Sửa Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(18, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 10);
            this.panel1.TabIndex = 2;
            // 
            // HD_NAME
            // 
            this.HD_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_NAME.Location = new System.Drawing.Point(248, 108);
            this.HD_NAME.MaxLength = 300;
            this.HD_NAME.Multiline = true;
            this.HD_NAME.Name = "HD_NAME";
            this.HD_NAME.Size = new System.Drawing.Size(288, 27);
            this.HD_NAME.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Họ  và Tên: *";
            // 
            // HD_EMAIL
            // 
            this.HD_EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_EMAIL.Location = new System.Drawing.Point(248, 163);
            this.HD_EMAIL.MaxLength = 300;
            this.HD_EMAIL.Multiline = true;
            this.HD_EMAIL.Name = "HD_EMAIL";
            this.HD_EMAIL.Size = new System.Drawing.Size(352, 27);
            this.HD_EMAIL.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Email: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Số Điện Thoại: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Địa Chỉ: *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Lương: *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(89, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày Thuê: *";
            // 
            // HD_PHONE
            // 
            this.HD_PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_PHONE.Location = new System.Drawing.Point(248, 226);
            this.HD_PHONE.MaxLength = 40;
            this.HD_PHONE.Multiline = true;
            this.HD_PHONE.Name = "HD_PHONE";
            this.HD_PHONE.Size = new System.Drawing.Size(151, 27);
            this.HD_PHONE.TabIndex = 36;
            // 
            // HD_ADDRESS
            // 
            this.HD_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ADDRESS.Location = new System.Drawing.Point(248, 277);
            this.HD_ADDRESS.MaxLength = 10;
            this.HD_ADDRESS.Multiline = true;
            this.HD_ADDRESS.Name = "HD_ADDRESS";
            this.HD_ADDRESS.Size = new System.Drawing.Size(544, 27);
            this.HD_ADDRESS.TabIndex = 37;
            // 
            // HD_SALARY
            // 
            this.HD_SALARY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_SALARY.Location = new System.Drawing.Point(248, 333);
            this.HD_SALARY.MaxLength = 10;
            this.HD_SALARY.Multiline = true;
            this.HD_SALARY.Name = "HD_SALARY";
            this.HD_SALARY.Size = new System.Drawing.Size(151, 27);
            this.HD_SALARY.TabIndex = 38;
            // 
            // DT_HIREDATE
            // 
            this.DT_HIREDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_HIREDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_HIREDATE.Location = new System.Drawing.Point(248, 388);
            this.DT_HIREDATE.Name = "DT_HIREDATE";
            this.DT_HIREDATE.Size = new System.Drawing.Size(151, 29);
            this.DT_HIREDATE.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(422, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "(VNĐ)";
            // 
            // BTN_EMPLOYEE
            // 
            this.BTN_EMPLOYEE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_EMPLOYEE.FlatAppearance.BorderSize = 0;
            this.BTN_EMPLOYEE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_EMPLOYEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EMPLOYEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EMPLOYEE.ForeColor = System.Drawing.Color.White;
            this.BTN_EMPLOYEE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EMPLOYEE.Location = new System.Drawing.Point(415, 468);
            this.BTN_EMPLOYEE.Name = "BTN_EMPLOYEE";
            this.BTN_EMPLOYEE.Size = new System.Drawing.Size(127, 54);
            this.BTN_EMPLOYEE.TabIndex = 43;
            this.BTN_EMPLOYEE.Text = "Lưu";
            this.BTN_EMPLOYEE.UseVisualStyleBackColor = false;
            this.BTN_EMPLOYEE.Click += new System.EventHandler(this.BTN_EMPLOYEE_Click);
            // 
            // BTN_EXIT
            // 
            this.BTN_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_EXIT.FlatAppearance.BorderSize = 0;
            this.BTN_EXIT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EXIT.ForeColor = System.Drawing.Color.White;
            this.BTN_EXIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EXIT.Location = new System.Drawing.Point(681, 468);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(127, 54);
            this.BTN_EXIT.TabIndex = 42;
            this.BTN_EXIT.Text = "Hủy";
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_RESET.FlatAppearance.BorderSize = 0;
            this.BTN_RESET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_RESET.ForeColor = System.Drawing.Color.White;
            this.BTN_RESET.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_RESET.Location = new System.Drawing.Point(548, 468);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(127, 54);
            this.BTN_RESET.TabIndex = 41;
            this.BTN_RESET.Text = "Làm Mới";
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // HD_ID
            // 
            this.HD_ID.Enabled = false;
            this.HD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ID.Location = new System.Drawing.Point(746, 21);
            this.HD_ID.MaxLength = 300;
            this.HD_ID.Multiline = true;
            this.HD_ID.Name = "HD_ID";
            this.HD_ID.Size = new System.Drawing.Size(74, 27);
            this.HD_ID.TabIndex = 44;
            this.HD_ID.Visible = false;
            // 
            // DetailEmPloyee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 534);
            this.Controls.Add(this.HD_ID);
            this.Controls.Add(this.BTN_EMPLOYEE);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_RESET);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DT_HIREDATE);
            this.Controls.Add(this.HD_SALARY);
            this.Controls.Add(this.HD_ADDRESS);
            this.Controls.Add(this.HD_PHONE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HD_EMAIL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HD_NAME);
            this.Controls.Add(this.LBL_HEADER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailEmPloyee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailEmPloyee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_HEADER;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox HD_NAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HD_EMAIL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox HD_PHONE;
        private System.Windows.Forms.TextBox HD_ADDRESS;
        private System.Windows.Forms.TextBox HD_SALARY;
        private System.Windows.Forms.DateTimePicker DT_HIREDATE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_EMPLOYEE;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.TextBox HD_ID;
    }
}