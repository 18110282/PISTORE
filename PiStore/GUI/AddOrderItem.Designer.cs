
namespace PiStore.GUI
{
    partial class AddOrderItem
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
            this.CB_SAN = new System.Windows.Forms.ComboBox();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_NEXT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LBL_HEADER = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HD_ORDERID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NU_SOLUONG = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV_NHANVIEN = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NU_SOLUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NHANVIEN)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_SAN
            // 
            this.CB_SAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_SAN.FormattingEnabled = true;
            this.CB_SAN.Location = new System.Drawing.Point(233, 99);
            this.CB_SAN.Name = "CB_SAN";
            this.CB_SAN.Size = new System.Drawing.Size(365, 32);
            this.CB_SAN.TabIndex = 90;
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
            this.BTN_EXIT.Location = new System.Drawing.Point(471, 560);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(127, 54);
            this.BTN_EXIT.TabIndex = 89;
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
            this.BTN_NEXT.Location = new System.Drawing.Point(315, 560);
            this.BTN_NEXT.Name = "BTN_NEXT";
            this.BTN_NEXT.Size = new System.Drawing.Size(127, 54);
            this.BTN_NEXT.TabIndex = 88;
            this.BTN_NEXT.Text = "Hoàn Tất";
            this.BTN_NEXT.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 83;
            this.label2.Text = "Chọn sản phẩm:*";
            // 
            // LBL_HEADER
            // 
            this.LBL_HEADER.AutoSize = true;
            this.LBL_HEADER.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HEADER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_HEADER.Location = new System.Drawing.Point(-4, 17);
            this.LBL_HEADER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_HEADER.Name = "LBL_HEADER";
            this.LBL_HEADER.Size = new System.Drawing.Size(378, 41);
            this.LBL_HEADER.TabIndex = 81;
            this.LBL_HEADER.Text = "Tạo Đơn Đặt Hàng (2)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(3, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 10);
            this.panel1.TabIndex = 80;
            // 
            // HD_ORDERID
            // 
            this.HD_ORDERID.Enabled = false;
            this.HD_ORDERID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ORDERID.Location = new System.Drawing.Point(537, 28);
            this.HD_ORDERID.MaxLength = 10;
            this.HD_ORDERID.Multiline = true;
            this.HD_ORDERID.Name = "HD_ORDERID";
            this.HD_ORDERID.Size = new System.Drawing.Size(61, 27);
            this.HD_ORDERID.TabIndex = 92;
            this.HD_ORDERID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(102, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Số Lượng:*";
            // 
            // NU_SOLUONG
            // 
            this.NU_SOLUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NU_SOLUONG.Location = new System.Drawing.Point(233, 146);
            this.NU_SOLUONG.Name = "NU_SOLUONG";
            this.NU_SOLUONG.Size = new System.Drawing.Size(88, 29);
            this.NU_SOLUONG.TabIndex = 95;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(485, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 96;
            this.button1.Text = "Thêm Vào";
            this.button1.UseVisualStyleBackColor = false;
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
            this.DGV_NHANVIEN.Location = new System.Drawing.Point(7, 181);
            this.DGV_NHANVIEN.Name = "DGV_NHANVIEN";
            this.DGV_NHANVIEN.Size = new System.Drawing.Size(591, 373);
            this.DGV_NHANVIEN.TabIndex = 97;
            // 
            // AddOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 647);
            this.Controls.Add(this.DGV_NHANVIEN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NU_SOLUONG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HD_ORDERID);
            this.Controls.Add(this.CB_SAN);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_NEXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL_HEADER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrderItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderItem";
            ((System.ComponentModel.ISupportInitialize)(this.NU_SOLUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NHANVIEN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_SAN;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Button BTN_NEXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_HEADER;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox HD_ORDERID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NU_SOLUONG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_NHANVIEN;
    }
}