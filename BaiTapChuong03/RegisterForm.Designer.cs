namespace BaiTapChuong03
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnQuayLai;

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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(180, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(164, 30);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // labels
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(35, 75);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(92, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Tên đăng nhập:";
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 115);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(58, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu:";
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(35, 155);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(109, 15);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Nhập lại mật khẩu:";
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(35, 195);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(35, 235);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(72, 15);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Họ và tên:";
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(35, 275);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(65, 15);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Ngày sinh:";
            // 
            // text boxes
            // 
            this.txtUsername.Location = new System.Drawing.Point(170, 72);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.TabIndex = 7;
            this.txtPassword.Location = new System.Drawing.Point(170, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Location = new System.Drawing.Point(170, 152);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 23);
            this.txtConfirmPassword.TabIndex = 9;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtEmail.Location = new System.Drawing.Point(170, 192);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 10;
            this.txtFullName.Location = new System.Drawing.Point(170, 232);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 23);
            this.txtFullName.TabIndex = 11;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(170, 272);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(150, 23);
            this.dtpBirthday.TabIndex = 12;
            // 
            // buttons
            // 
            this.btnDangKy.Location = new System.Drawing.Point(170, 325);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 35);
            this.btnDangKy.TabIndex = 13;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            this.btnQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuayLai.Location = new System.Drawing.Point(310, 325);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(120, 35);
            this.btnQuayLai.TabIndex = 14;
            this.btnQuayLai.Text = "Quay lại / Hủy";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // RegisterForm
            // 
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuayLai;
            this.ClientSize = new System.Drawing.Size(520, 390);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}