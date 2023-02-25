
namespace PiStore.GUI
{
    partial class QLDONHANG
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
            this.BTN_THEM = new System.Windows.Forms.Button();
            this.BTN_XOA = new System.Windows.Forms.Button();
            this.BTN_SUA = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.BTN_THEM.Location = new System.Drawing.Point(459, 484);
            this.BTN_THEM.Name = "BTN_THEM";
            this.BTN_THEM.Size = new System.Drawing.Size(127, 54);
            this.BTN_THEM.TabIndex = 35;
            this.BTN_THEM.Text = "Thêm";
            this.BTN_THEM.UseVisualStyleBackColor = false;
            this.BTN_THEM.Click += new System.EventHandler(this.BTN_THEM_Click);
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
            this.BTN_XOA.Location = new System.Drawing.Point(725, 484);
            this.BTN_XOA.Name = "BTN_XOA";
            this.BTN_XOA.Size = new System.Drawing.Size(127, 54);
            this.BTN_XOA.TabIndex = 34;
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
            this.BTN_SUA.Location = new System.Drawing.Point(592, 484);
            this.BTN_SUA.Name = "BTN_SUA";
            this.BTN_SUA.Size = new System.Drawing.Size(127, 54);
            this.BTN_SUA.TabIndex = 33;
            this.BTN_SUA.Text = "Sửa";
            this.BTN_SUA.UseVisualStyleBackColor = false;
            // 
            // QLDONHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 590);
            this.Controls.Add(this.BTN_THEM);
            this.Controls.Add(this.BTN_XOA);
            this.Controls.Add(this.BTN_SUA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLDONHANG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLDONHANG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_THEM;
        private System.Windows.Forms.Button BTN_XOA;
        private System.Windows.Forms.Button BTN_SUA;
    }
}