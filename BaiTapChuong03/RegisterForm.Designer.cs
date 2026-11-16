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
        private System.Windows.Forms.Label labelTrangThai;
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
            lblTieuDe = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblEmail = new Label();
            lblFullName = new Label();
            lblServerIP = new Label();
            lblServerPort = new Label();
            labelTrangThai = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtEmail = new TextBox();
            txtFullName = new TextBox();
            txtServerIP = new TextBox();
            txtServerPort = new TextBox();
            btnDangKy = new Button();
            btnQuayLai = new Button();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDe.Location = new Point(257, 33);
            lblTieuDe.Margin = new Padding(4, 0, 4, 0);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(350, 45);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(50, 125);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(133, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tên đăng nhập:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 192);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Mật khẩu:";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(50, 258);
            lblConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(160, 25);
            lblConfirmPassword.TabIndex = 3;
            lblConfirmPassword.Text = "Nhập lại mật khẩu:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(50, 325);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 25);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(50, 392);
            lblFullName.Margin = new Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(93, 25);
            lblFullName.TabIndex = 5;
            lblFullName.Text = "Họ và tên:";
            // 
            // lblServerIP
            // 
            lblServerIP.AutoSize = true;
            lblServerIP.Location = new Point(55, 453);
            lblServerIP.Margin = new Padding(4, 0, 4, 0);
            lblServerIP.Name = "lblServerIP";
            lblServerIP.Size = new Size(85, 25);
            lblServerIP.TabIndex = 13;
            lblServerIP.Text = "IP Server:";
            // 
            // lblServerPort
            // 
            lblServerPort.AutoSize = true;
            lblServerPort.Location = new Point(50, 506);
            lblServerPort.Margin = new Padding(4, 0, 4, 0);
            lblServerPort.Name = "lblServerPort";
            lblServerPort.Size = new Size(113, 25);
            lblServerPort.TabIndex = 15;
            lblServerPort.Text = "Cổng Server:";
            // 
            // labelTrangThai
            // 
            labelTrangThai.AutoSize = true;
            labelTrangThai.ForeColor = Color.DimGray;
            labelTrangThai.Location = new Point(55, 572);
            labelTrangThai.Margin = new Padding(4, 0, 4, 0);
            labelTrangThai.Name = "labelTrangThai";
            labelTrangThai.Size = new Size(96, 25);
            labelTrangThai.TabIndex = 17;
            labelTrangThai.Text = "Trạng Thái:";
            labelTrangThai.Click += labelTrangThai_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(243, 120);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(427, 31);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(243, 187);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(427, 31);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(243, 253);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(427, 31);
            txtConfirmPassword.TabIndex = 9;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(243, 320);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(427, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(243, 387);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(427, 31);
            txtFullName.TabIndex = 11;
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(243, 447);
            txtServerIP.Margin = new Padding(4, 5, 4, 5);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(99, 31);
            txtServerIP.TabIndex = 14;
            txtServerIP.Text = "127.0.0.1";
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(243, 506);
            txtServerPort.Margin = new Padding(4, 5, 4, 5);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(76, 31);
            txtServerPort.TabIndex = 16;
            txtServerPort.Text = "8386";
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(243, 645);
            btnDangKy.Margin = new Padding(4, 5, 4, 5);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(171, 58);
            btnDangKy.TabIndex = 18;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.DialogResult = DialogResult.Cancel;
            btnQuayLai.Location = new Point(436, 645);
            btnQuayLai.Margin = new Padding(4, 5, 4, 5);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(171, 58);
            btnQuayLai.TabIndex = 19;
            btnQuayLai.Text = "Quay lại / Hủy";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // RegisterForm
            // 
            AcceptButton = btnDangKy;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnQuayLai;
            ClientSize = new Size(743, 808);
            Controls.Add(btnQuayLai);
            Controls.Add(btnDangKy);
            Controls.Add(labelTrangThai);
            Controls.Add(txtServerPort);
            Controls.Add(lblServerPort);
            Controls.Add(txtServerIP);
            Controls.Add(lblServerIP);
            Controls.Add(txtFullName);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblFullName);
            Controls.Add(lblEmail);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đăng ký tài khoản";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}