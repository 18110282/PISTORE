
namespace PiStore.GUI
{
    partial class DETAILORDER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_DETAILSORDER = new System.Windows.Forms.DataGridView();
            this.HD_ORDERID = new System.Windows.Forms.TextBox();
            this.BTN_EXIT = new System.Windows.Forms.Button();
            this.BTN_PRINT = new System.Windows.Forms.Button();
            this.LBL_HEADER = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETAILSORDER)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_DETAILSORDER
            // 
            this.DGV_DETAILSORDER.BackgroundColor = System.Drawing.Color.White;
            this.DGV_DETAILSORDER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_DETAILSORDER.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_DETAILSORDER.Location = new System.Drawing.Point(88, 217);
            this.DGV_DETAILSORDER.Name = "DGV_DETAILSORDER";
            this.DGV_DETAILSORDER.Size = new System.Drawing.Size(607, 307);
            this.DGV_DETAILSORDER.TabIndex = 108;
            // 
            // HD_ORDERID
            // 
            this.HD_ORDERID.Enabled = false;
            this.HD_ORDERID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HD_ORDERID.Location = new System.Drawing.Point(634, -62);
            this.HD_ORDERID.MaxLength = 10;
            this.HD_ORDERID.Multiline = true;
            this.HD_ORDERID.Name = "HD_ORDERID";
            this.HD_ORDERID.Size = new System.Drawing.Size(61, 27);
            this.HD_ORDERID.TabIndex = 104;
            this.HD_ORDERID.Visible = false;
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
            this.BTN_EXIT.Location = new System.Drawing.Point(661, 530);
            this.BTN_EXIT.Name = "BTN_EXIT";
            this.BTN_EXIT.Size = new System.Drawing.Size(127, 54);
            this.BTN_EXIT.TabIndex = 102;
            this.BTN_EXIT.Text = "Thoát";
            this.BTN_EXIT.UseVisualStyleBackColor = false;
            // 
            // BTN_PRINT
            // 
            this.BTN_PRINT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_PRINT.FlatAppearance.BorderSize = 0;
            this.BTN_PRINT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_PRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRINT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRINT.ForeColor = System.Drawing.Color.White;
            this.BTN_PRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PRINT.Location = new System.Drawing.Point(528, 530);
            this.BTN_PRINT.Name = "BTN_PRINT";
            this.BTN_PRINT.Size = new System.Drawing.Size(127, 54);
            this.BTN_PRINT.TabIndex = 101;
            this.BTN_PRINT.Text = "Xuất Bill";
            this.BTN_PRINT.UseVisualStyleBackColor = false;
            // 
            // LBL_HEADER
            // 
            this.LBL_HEADER.AutoSize = true;
            this.LBL_HEADER.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HEADER.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_HEADER.Location = new System.Drawing.Point(93, -73);
            this.LBL_HEADER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_HEADER.Name = "LBL_HEADER";
            this.LBL_HEADER.Size = new System.Drawing.Size(378, 41);
            this.LBL_HEADER.TabIndex = 99;
            this.LBL_HEADER.Text = "Tạo Đơn Đặt Hàng (2)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(100, -29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 10);
            this.panel1.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(-4, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 110;
            this.label1.Text = "Chi Tiết Đơn Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(3, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(802, 10);
            this.panel2.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 111;
            this.label2.Text = "Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 112;
            this.label3.Text = "Khách Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 113;
            this.label4.Text = "Ngày Tạo:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel3.Location = new System.Drawing.Point(528, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 108);
            this.panel3.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(572, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 33);
            this.label5.TabIndex = 114;
            this.label5.Text = "17000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(185, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 24);
            this.label6.TabIndex = 115;
            this.label6.Text = "Phạm Nguyễn Xuân Quang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(185, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 24);
            this.label7.TabIndex = 116;
            this.label7.Text = "Phạm Nguyễn Xuân Quang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(185, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 24);
            this.label8.TabIndex = 117;
            this.label8.Text = "2023-11-11 15:17:20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label9.Location = new System.Drawing.Point(331, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 42);
            this.label9.TabIndex = 118;
            this.label9.Text = "#1234";
            // 
            // DETAILORDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 596);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DGV_DETAILSORDER);
            this.Controls.Add(this.HD_ORDERID);
            this.Controls.Add(this.BTN_EXIT);
            this.Controls.Add(this.BTN_PRINT);
            this.Controls.Add(this.LBL_HEADER);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DETAILORDER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DETAILORDER";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DETAILSORDER)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_DETAILSORDER;
        private System.Windows.Forms.TextBox HD_ORDERID;
        private System.Windows.Forms.Button BTN_EXIT;
        private System.Windows.Forms.Button BTN_PRINT;
        private System.Windows.Forms.Label LBL_HEADER;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}