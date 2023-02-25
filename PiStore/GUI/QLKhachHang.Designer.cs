
namespace PiStore.GUI
{
    partial class QLKhachHang
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
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_THEM = new System.Windows.Forms.Button();
            this.BTN_XOA = new System.Windows.Forms.Button();
            this.BTN_SUA = new System.Windows.Forms.Button();
            this.DGV_CLIENT = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CLIENT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-12, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 92);
            this.panel1.TabIndex = 28;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 44);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quản Lý Khách Hàng";
            // 
            // BTN_THEM
            // 
            this.BTN_THEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_THEM.FlatAppearance.BorderSize = 0;
            this.BTN_THEM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_THEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_THEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_THEM.ForeColor = System.Drawing.Color.White;
            this.BTN_THEM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_THEM.Location = new System.Drawing.Point(515, 572);
            this.BTN_THEM.Name = "BTN_THEM";
            this.BTN_THEM.Size = new System.Drawing.Size(127, 54);
            this.BTN_THEM.TabIndex = 32;
            this.BTN_THEM.Text = "Thêm";
            this.BTN_THEM.UseVisualStyleBackColor = false;
            // 
            // BTN_XOA
            // 
            this.BTN_XOA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_XOA.FlatAppearance.BorderSize = 0;
            this.BTN_XOA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_XOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_XOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_XOA.ForeColor = System.Drawing.Color.White;
            this.BTN_XOA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_XOA.Location = new System.Drawing.Point(781, 572);
            this.BTN_XOA.Name = "BTN_XOA";
            this.BTN_XOA.Size = new System.Drawing.Size(127, 54);
            this.BTN_XOA.TabIndex = 31;
            this.BTN_XOA.Text = "Xóa";
            this.BTN_XOA.UseVisualStyleBackColor = false;
            // 
            // BTN_SUA
            // 
            this.BTN_SUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_SUA.FlatAppearance.BorderSize = 0;
            this.BTN_SUA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(78)))), ((int)(((byte)(139)))));
            this.BTN_SUA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_SUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SUA.ForeColor = System.Drawing.Color.White;
            this.BTN_SUA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_SUA.Location = new System.Drawing.Point(648, 572);
            this.BTN_SUA.Name = "BTN_SUA";
            this.BTN_SUA.Size = new System.Drawing.Size(127, 54);
            this.BTN_SUA.TabIndex = 30;
            this.BTN_SUA.Text = "Sửa";
            this.BTN_SUA.UseVisualStyleBackColor = false;
            // 
            // DGV_CLIENT
            // 
            this.DGV_CLIENT.BackgroundColor = System.Drawing.Color.White;
            this.DGV_CLIENT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_CLIENT.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CLIENT.Location = new System.Drawing.Point(1, 139);
            this.DGV_CLIENT.Name = "DGV_CLIENT";
            this.DGV_CLIENT.Size = new System.Drawing.Size(907, 416);
            this.DGV_CLIENT.TabIndex = 29;
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_THEM);
            this.Controls.Add(this.BTN_XOA);
            this.Controls.Add(this.BTN_SUA);
            this.Controls.Add(this.DGV_CLIENT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CLIENT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTN_THEM;
        private System.Windows.Forms.Button BTN_XOA;
        private System.Windows.Forms.Button BTN_SUA;
        private System.Windows.Forms.DataGridView DGV_CLIENT;
    }
}