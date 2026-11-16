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
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.Label lblTrangThaiKetNoi;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtServerPort;
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
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.lblTrangThaiKetNoi = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
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
            // server connection
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(35, 315);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(62, 15);
            this.lblServerIP.TabIndex = 13;
            this.lblServerIP.Text = "IP Server:";
            this.txtServerIP.Location = new System.Drawing.Point(170, 312);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(180, 23);
            this.txtServerIP.TabIndex = 14;
            this.txtServerIP.Text = "127.0.0.1";
            this.lblServerPort.AutoSize = true;
            this.lblServerPort.Location = new System.Drawing.Point(35, 355);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(69, 15);
            this.lblServerPort.TabIndex = 15;
            this.lblServerPort.Text = "Cổng Server:";
            this.txtServerPort.Location = new System.Drawing.Point(170, 352);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(120, 23);
            this.txtServerPort.TabIndex = 16;
            this.txtServerPort.Text = "8386";
            this.lblTrangThaiKetNoi.AutoSize = true;
            this.lblTrangThaiKetNoi.ForeColor = System.Drawing.Color.DimGray;
            this.lblTrangThaiKetNoi.Location = new System.Drawing.Point(35, 390);
            this.lblTrangThaiKetNoi.Name = "lblTrangThaiKetNoi";
            this.lblTrangThaiKetNoi.Size = new System.Drawing.Size(88, 15);
            this.lblTrangThaiKetNoi.TabIndex = 17;
            this.lblTrangThaiKetNoi.Text = "Chưa kết nối";
            // 
            // buttons
            // 
            this.btnDangKy.Location = new System.Drawing.Point(170, 425);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(120, 35);
            this.btnDangKy.TabIndex = 18;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            this.btnQuayLai.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuayLai.Location = new System.Drawing.Point(310, 425);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(120, 35);
            this.btnQuayLai.TabIndex = 19;
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
            this.ClientSize = new System.Drawing.Size(520, 485);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.lblTrangThaiKetNoi);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblServerIP);
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