
namespace PiStore.GUI
{
    partial class QLNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DGV_NHANVIEN = new System.Windows.Forms.DataGridView();
            this.BTN_EMPLOYEE = new System.Windows.Forms.Button();
            this.BTN_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_CLIENT = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NHANVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 92);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 44);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quản Lý Nhân Viên";
            // 
            // DGV_NHANVIEN
            // 
            this.DGV_NHANVIEN.BackgroundColor = System.Drawing.Color.White;
            this.DGV_NHANVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_NHANVIEN.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_NHANVIEN.Location = new System.Drawing.Point(12, 140);
            this.DGV_NHANVIEN.Name = "DGV_NHANVIEN";
            this.DGV_NHANVIEN.Size = new System.Drawing.Size(907, 416);
            this.DGV_NHANVIEN.TabIndex = 2;
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
            this.BTN_EMPLOYEE.Location = new System.Drawing.Point(526, 573);
            this.BTN_EMPLOYEE.Name = "BTN_EMPLOYEE";
            this.BTN_EMPLOYEE.Size = new System.Drawing.Size(127, 54);
            this.BTN_EMPLOYEE.TabIndex = 27;
            this.BTN_EMPLOYEE.Text = "Thêm";
            this.BTN_EMPLOYEE.UseVisualStyleBackColor = false;
            this.BTN_EMPLOYEE.Click += new System.EventHandler(this.BTN_EMPLOYEE_Click);
            // 
            // BTN_PRODUCT
            // 
            this.BTN_PRODUCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_PRODUCT.FlatAppearance.BorderSize = 0;
            this.BTN_PRODUCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PRODUCT.Location = new System.Drawing.Point(792, 573);
            this.BTN_PRODUCT.Name = "BTN_PRODUCT";
            this.BTN_PRODUCT.Size = new System.Drawing.Size(127, 54);
            this.BTN_PRODUCT.TabIndex = 26;
            this.BTN_PRODUCT.Text = "Xóa";
            this.BTN_PRODUCT.UseVisualStyleBackColor = false;
            this.BTN_PRODUCT.Click += new System.EventHandler(this.BTN_PRODUCT_Click);
            // 
            // BTN_CLIENT
            // 
            this.BTN_CLIENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_CLIENT.FlatAppearance.BorderSize = 0;
            this.BTN_CLIENT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_CLIENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLIENT.ForeColor = System.Drawing.Color.White;
            this.BTN_CLIENT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLIENT.Location = new System.Drawing.Point(659, 573);
            this.BTN_CLIENT.Name = "BTN_CLIENT";
            this.BTN_CLIENT.Size = new System.Drawing.Size(127, 54);
            this.BTN_CLIENT.TabIndex = 25;
            this.BTN_CLIENT.Text = "Sửa";
            this.BTN_CLIENT.UseVisualStyleBackColor = false;
            this.BTN_CLIENT.Click += new System.EventHandler(this.BTN_CLIENT_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::PiStore.Properties.Resources.Close_Icon;
            this.btnExit.Location = new System.Drawing.Point(875, 19);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 46);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 28;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 668);
            this.Controls.Add(this.BTN_EMPLOYEE);
            this.Controls.Add(this.BTN_PRODUCT);
            this.Controls.Add(this.BTN_CLIENT);
            this.Controls.Add(this.DGV_NHANVIEN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NHANVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGV_NHANVIEN;
        private System.Windows.Forms.Button BTN_EMPLOYEE;
        private System.Windows.Forms.Button BTN_PRODUCT;
        private System.Windows.Forms.Button BTN_CLIENT;
        private System.Windows.Forms.PictureBox btnExit;
    }
}