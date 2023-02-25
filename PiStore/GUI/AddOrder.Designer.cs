
namespace PiStore.GUI
{
    partial class AddOrder
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
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.HD_ADDRESS = new System.Windows.Forms.TextBox();
            this.HD_PHONE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_HEADER = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CB_NHANVIEN = new System.Windows.Forms.ComboBox();
            this.CB_KHACHHANG = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.BTN_EXIT.Location = new System.Drawing.Point(674, 428);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(127, 54);
            this.BTN_EXIT.TabIndex = 75;
            this.BTN_EXIT.Text = "Hủy";
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            this.BTN_EXIT.Click += new System.EventHandler(this.BTN_EXIT_Click);
            // 
            // BTN_NEXT
            // 
            this.BTN_NEXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_NEXT.FlatAppearance.BorderSize = 0;
            this.BTN_NEXT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEXT.ForeColor = System.Drawing.Color.White;
            this.BTN_NEXT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_NEXT.Location = new System.Drawing.Point(541, 428);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(127, 54);
            this.BTN_NEXT.TabIndex = 74;
            this.BTN_NEXT.Text = "Tiếp Theo";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            this.BTN_NEXT.Click += new System.EventHandler(this.BTN_NEXT_Click);
            // 
            // HD_ADDRESS
            // 
            this.HD_ADDRESS.Enabled = false;
            this.HD_ADDRESS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ADDRESS.Location = new System.Drawing.Point(241, 310);
            this.HD_ADDRESS.MaxLength = 10;
            this.HD_ADDRESS.Multiline = true;
            this.HD_ADDRESS.Name = "HD_ADDRESS";
            this.HD_ADDRESS.Size = new System.Drawing.Size(524, 27);
            this.HD_ADDRESS.TabIndex = 73;
            // 
            // HD_PHONE
            // 
            this.HD_PHONE.Enabled = false;
            this.HD_PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_PHONE.Location = new System.Drawing.Point(241, 262);
            this.HD_PHONE.MaxLength = 40;
            this.HD_PHONE.Multiline = true;
            this.HD_PHONE.Name = "HD_PHONE";
            this.HD_PHONE.Size = new System.Drawing.Size(151, 27);
            this.HD_PHONE.TabIndex = 72;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "Địa Chỉ: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 70;
            this.label4.Text = "Số Điện Thoại:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nhân Viên :*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 67;
            this.label1.Text = "Chọn Khách Hàng: *";
            // 
            // LBL_HEADER
            // 
            this.LBL_HEADER.AutoSize = true;
            this.LBL_HEADER.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HEADER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_HEADER.Location = new System.Drawing.Point(4, 13);
            this.LBL_HEADER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_HEADER.Name = "LBL_HEADER";
            this.LBL_HEADER.Size = new System.Drawing.Size(378, 41);
            this.LBL_HEADER.TabIndex = 65;
            this.LBL_HEADER.Text = "Tạo Đơn Đặt Hàng (1)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(11, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 10);
            this.panel1.TabIndex = 64;
            // 
            // CB_NHANVIEN
            // 
            this.CB_NHANVIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_NHANVIEN.FormattingEnabled = true;
            this.CB_NHANVIEN.Location = new System.Drawing.Point(241, 130);
            this.CB_NHANVIEN.Name = "CB_NHANVIEN";
            this.CB_NHANVIEN.Size = new System.Drawing.Size(354, 32);
            this.CB_NHANVIEN.TabIndex = 78;
            this.CB_NHANVIEN.SelectedIndexChanged += new System.EventHandler(this.CB_NHANVIEN_SelectedIndexChanged);
            // 
            // CB_KHACHHANG
            // 
            this.CB_KHACHHANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_KHACHHANG.FormattingEnabled = true;
            this.CB_KHACHHANG.Location = new System.Drawing.Point(241, 211);
            this.CB_KHACHHANG.Name = "CB_KHACHHANG";
            this.CB_KHACHHANG.Size = new System.Drawing.Size(354, 32);
            this.CB_KHACHHANG.TabIndex = 79;
            this.CB_KHACHHANG.SelectedIndexChanged += new System.EventHandler(this.CB_KHACHHANG_SelectedIndexChanged);
            this.CB_KHACHHANG.Click += new System.EventHandler(this.CB_KHACHHANG_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 495);
            this.Controls.Add(this.CB_KHACHHANG);
            this.Controls.Add(this.CB_NHANVIEN);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_NEXT);
            this.Controls.Add(this.HD_ADDRESS);
            this.Controls.Add(this.HD_PHONE);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_HEADER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Button BTN_NEXT;
        private System.Windows.Forms.TextBox HD_ADDRESS;
        private System.Windows.Forms.TextBox HD_PHONE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_HEADER;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CB_NHANVIEN;
        private System.Windows.Forms.ComboBox CB_KHACHHANG;
    }
}