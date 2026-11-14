namespace BaiTapChuong03
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblGioiThieu;
        private System.Windows.Forms.Button btnMoDangKy;

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
            this.lblGioiThieu = new System.Windows.Forms.Label();
            this.btnMoDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGioiThieu
            // 
            this.lblGioiThieu.AutoSize = true;
            this.lblGioiThieu.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGioiThieu.Location = new System.Drawing.Point(135, 55);
            this.lblGioiThieu.Name = "lblGioiThieu";
            this.lblGioiThieu.Size = new System.Drawing.Size(210, 25);
            this.lblGioiThieu.TabIndex = 0;
            this.lblGioiThieu.Text = "Đăng nhập hệ thống";
            // 
            // btnMoDangKy
            // 
            this.btnMoDangKy.Location = new System.Drawing.Point(155, 125);
            this.btnMoDangKy.Name = "btnMoDangKy";
            this.btnMoDangKy.Size = new System.Drawing.Size(170, 35);
            this.btnMoDangKy.TabIndex = 1;
            this.btnMoDangKy.Text = "Đăng ký tài khoản";
            this.btnMoDangKy.UseVisualStyleBackColor = true;
            this.btnMoDangKy.Click += new System.EventHandler(this.btnMoDangKy_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 260);
            this.Controls.Add(this.btnMoDangKy);
            this.Controls.Add(this.lblGioiThieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}