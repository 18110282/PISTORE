
namespace PiStore.GUI
{
    partial class DetailClient
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
            this.HD_ID = new System.Windows.Forms.TextBox();
            this.BTN_EMPLOYEE = new System.Windows.Forms.Button();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.HD_ADDRESS = new System.Windows.Forms.TextBox();
            this.HD_PHONE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HD_EMAIL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HD_NAME = new System.Windows.Forms.TextBox();
            this.LBL_HEADER = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // HD_ID
            // 
            this.HD_ID.Enabled = false;
            this.HD_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ID.Location = new System.Drawing.Point(739, 22);
            this.HD_ID.MaxLength = 300;
            this.HD_ID.Multiline = true;
            this.HD_ID.Name = "HD_ID";
            this.HD_ID.Size = new System.Drawing.Size(74, 27);
            this.HD_ID.TabIndex = 63;
            this.HD_ID.Visible = false;
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
            this.BTN_EMPLOYEE.Location = new System.Drawing.Point(408, 425);
            this.BTN_EMPLOYEE.Name = "BTN_EMPLOYEE";
            this.BTN_EMPLOYEE.Size = new System.Drawing.Size(127, 54);
            this.BTN_EMPLOYEE.TabIndex = 62;
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
            this.BTN_EXIT.Location = new System.Drawing.Point(674, 425);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(127, 54);
            this.BTN_EXIT.TabIndex = 61;
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
            this.BTN_RESET.Location = new System.Drawing.Point(541, 425);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(127, 54);
            this.BTN_RESET.TabIndex = 60;
            this.BTN_RESET.Text = "Làm Mới";
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // HD_ADDRESS
            // 
            this.HD_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ADDRESS.Location = new System.Drawing.Point(241, 310);
            this.HD_ADDRESS.MaxLength = 10;
            this.HD_ADDRESS.Multiline = true;
            this.HD_ADDRESS.Name = "HD_ADDRESS";
            this.HD_ADDRESS.Size = new System.Drawing.Size(544, 27);
            this.HD_ADDRESS.TabIndex = 56;
            // 
            // HD_PHONE
            // 
            this.HD_PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_PHONE.Location = new System.Drawing.Point(241, 259);
            this.HD_PHONE.MaxLength = 40;
            this.HD_PHONE.Multiline = true;
            this.HD_PHONE.Name = "HD_PHONE";
            this.HD_PHONE.Size = new System.Drawing.Size(151, 27);
            this.HD_PHONE.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Địa Chỉ: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Số Điện Thoại: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Email: *";
            // 
            // HD_EMAIL
            // 
            this.HD_EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_EMAIL.Location = new System.Drawing.Point(241, 196);
            this.HD_EMAIL.MaxLength = 300;
            this.HD_EMAIL.Multiline = true;
            this.HD_EMAIL.Name = "HD_EMAIL";
            this.HD_EMAIL.Size = new System.Drawing.Size(352, 27);
            this.HD_EMAIL.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Họ  và Tên: *";
            // 
            // HD_NAME
            // 
            this.HD_NAME.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_NAME.Location = new System.Drawing.Point(241, 141);
            this.HD_NAME.MaxLength = 300;
            this.HD_NAME.Multiline = true;
            this.HD_NAME.Name = "HD_NAME";
            this.HD_NAME.Size = new System.Drawing.Size(288, 27);
            this.HD_NAME.TabIndex = 47;
            // 
            // LBL_HEADER
            // 
            this.LBL_HEADER.AutoSize = true;
            this.LBL_HEADER.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HEADER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_HEADER.Location = new System.Drawing.Point(4, 10);
            this.LBL_HEADER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_HEADER.Name = "LBL_HEADER";
            this.LBL_HEADER.Size = new System.Drawing.Size(427, 41);
            this.LBL_HEADER.TabIndex = 46;
            this.LBL_HEADER.Text = "Thêm / Sửa Khách Hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(11, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 10);
            this.panel1.TabIndex = 45;
            // 
            // DetailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 495);
            this.Controls.Add(this.HD_ID);
            this.Controls.Add(this.BTN_EMPLOYEE);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_RESET);
            this.Controls.Add(this.HD_ADDRESS);
            this.Controls.Add(this.HD_PHONE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HD_EMAIL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HD_NAME);
            this.Controls.Add(this.LBL_HEADER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DetailClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetailClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HD_ID;
        private System.Windows.Forms.Button BTN_EMPLOYEE;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.TextBox HD_ADDRESS;
        private System.Windows.Forms.TextBox HD_PHONE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HD_EMAIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HD_NAME;
        private System.Windows.Forms.Label LBL_HEADER;
        private System.Windows.Forms.Panel panel1;
    }
}