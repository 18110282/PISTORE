
namespace PiStore
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.BTN_EMPLOYEE = new System.Windows.Forms.Button();
            this.BTN_ORDER = new System.Windows.Forms.Button();
            this.BTN_PRODUCT = new System.Windows.Forms.Button();
            this.BTN_CLIENT = new System.Windows.Forms.Button();
            this.BTN_BILL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.LBL_DATE = new System.Windows.Forms.Label();
            this.LBL_TIME = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 635);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(28, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 635);
            this.panel2.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::PiStore.Properties.Resources._12_121334_superman_symbol_clipart_removebg_preview;
            this.pbLogo.Location = new System.Drawing.Point(349, 252);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(226, 210);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 20;
            this.pbLogo.TabStop = false;
            // 
            // BTN_EMPLOYEE
            // 
            this.BTN_EMPLOYEE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BTN_EMPLOYEE.FlatAppearance.BorderSize = 0;
            this.BTN_EMPLOYEE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_EMPLOYEE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EMPLOYEE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EMPLOYEE.ForeColor = System.Drawing.Color.White;
            this.BTN_EMPLOYEE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_EMPLOYEE.Location = new System.Drawing.Point(44, 54);
            this.BTN_EMPLOYEE.Name = "BTN_EMPLOYEE";
            this.BTN_EMPLOYEE.Size = new System.Drawing.Size(214, 54);
            this.BTN_EMPLOYEE.TabIndex = 24;
            this.BTN_EMPLOYEE.Text = "Nhân Viên";
            this.BTN_EMPLOYEE.UseVisualStyleBackColor = false;
            this.BTN_EMPLOYEE.Click += new System.EventHandler(this.BTN_EMPLOYEE_Click);
            // 
            // BTN_ORDER
            // 
            this.BTN_ORDER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BTN_ORDER.FlatAppearance.BorderSize = 0;
            this.BTN_ORDER.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_ORDER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ORDER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ORDER.ForeColor = System.Drawing.Color.White;
            this.BTN_ORDER.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_ORDER.Location = new System.Drawing.Point(44, 114);
            this.BTN_ORDER.Name = "BTN_ORDER";
            this.BTN_ORDER.Size = new System.Drawing.Size(214, 54);
            this.BTN_ORDER.TabIndex = 23;
            this.BTN_ORDER.Text = "Đơn Đặt";
            this.BTN_ORDER.UseVisualStyleBackColor = false;
            // 
            // BTN_PRODUCT
            // 
            this.BTN_PRODUCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BTN_PRODUCT.FlatAppearance.BorderSize = 0;
            this.BTN_PRODUCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.BTN_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_PRODUCT.Location = new System.Drawing.Point(484, 54);
            this.BTN_PRODUCT.Name = "BTN_PRODUCT";
            this.BTN_PRODUCT.Size = new System.Drawing.Size(214, 54);
            this.BTN_PRODUCT.TabIndex = 22;
            this.BTN_PRODUCT.Text = "Sản Phẩm";
            this.BTN_PRODUCT.UseVisualStyleBackColor = false;
            // 
            // BTN_CLIENT
            // 
            this.BTN_CLIENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BTN_CLIENT.FlatAppearance.BorderSize = 0;
            this.BTN_CLIENT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_CLIENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_CLIENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CLIENT.ForeColor = System.Drawing.Color.White;
            this.BTN_CLIENT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_CLIENT.Location = new System.Drawing.Point(264, 54);
            this.BTN_CLIENT.Name = "BTN_CLIENT";
            this.BTN_CLIENT.Size = new System.Drawing.Size(214, 54);
            this.BTN_CLIENT.TabIndex = 21;
            this.BTN_CLIENT.Text = "Khách Hàng";
            this.BTN_CLIENT.UseVisualStyleBackColor = false;
            // 
            // BTN_BILL
            // 
            this.BTN_BILL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.BTN_BILL.FlatAppearance.BorderSize = 0;
            this.BTN_BILL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.BTN_BILL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_BILL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_BILL.ForeColor = System.Drawing.Color.White;
            this.BTN_BILL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_BILL.Location = new System.Drawing.Point(264, 114);
            this.BTN_BILL.Name = "BTN_BILL";
            this.BTN_BILL.Size = new System.Drawing.Size(214, 54);
            this.BTN_BILL.TabIndex = 25;
            this.BTN_BILL.Text = "Hóa Đơn";
            this.BTN_BILL.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(318, 464);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 77);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pi - Store";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(880, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 27;
            this.btnExit.TabStop = false;
            // 
            // LBL_DATE
            // 
            this.LBL_DATE.AutoSize = true;
            this.LBL_DATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DATE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_DATE.Location = new System.Drawing.Point(840, 641);
            this.LBL_DATE.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_DATE.Name = "LBL_DATE";
            this.LBL_DATE.Size = new System.Drawing.Size(37, 16);
            this.LBL_DATE.TabIndex = 29;
            this.LBL_DATE.Text = "time";
            // 
            // LBL_TIME
            // 
            this.LBL_TIME.AutoSize = true;
            this.LBL_TIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TIME.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LBL_TIME.Location = new System.Drawing.Point(837, 621);
            this.LBL_TIME.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_TIME.Name = "LBL_TIME";
            this.LBL_TIME.Size = new System.Drawing.Size(37, 16);
            this.LBL_TIME.TabIndex = 28;
            this.LBL_TIME.Text = "time";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 668);
            this.Controls.Add(this.LBL_DATE);
            this.Controls.Add(this.LBL_TIME);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_BILL);
            this.Controls.Add(this.BTN_EMPLOYEE);
            this.Controls.Add(this.BTN_ORDER);
            this.Controls.Add(this.BTN_PRODUCT);
            this.Controls.Add(this.BTN_CLIENT);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button BTN_EMPLOYEE;
        private System.Windows.Forms.Button BTN_ORDER;
        private System.Windows.Forms.Button BTN_PRODUCT;
        private System.Windows.Forms.Button BTN_CLIENT;
        private System.Windows.Forms.Button BTN_BILL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label LBL_DATE;
        private System.Windows.Forms.Label LBL_TIME;
        private System.Windows.Forms.Timer timer;
    }
}

