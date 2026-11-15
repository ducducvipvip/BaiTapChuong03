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
            lblGioiThieu = new Label();
            btnMoDangKy = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIP = new TextBox();
            txtPort = new TextBox();
            txtTenDangNhap = new TextBox();
            label5 = new Label();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            lblLoi = new Label();
            btnKetNoi = new Button();
            SuspendLayout();
            // 
            // lblGioiThieu
            // 
            lblGioiThieu.AutoSize = true;
            lblGioiThieu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGioiThieu.Location = new Point(130, 9);
            lblGioiThieu.Name = "lblGioiThieu";
            lblGioiThieu.Size = new Size(195, 25);
            lblGioiThieu.TabIndex = 0;
            lblGioiThieu.Text = "Đăng nhập hệ thống";
            // 
            // btnMoDangKy
            // 
            btnMoDangKy.Location = new Point(309, 213);
            btnMoDangKy.Name = "btnMoDangKy";
            btnMoDangKy.Size = new Size(117, 35);
            btnMoDangKy.TabIndex = 6;
            btnMoDangKy.Text = "Đăng ký tài khoản";
            btnMoDangKy.UseVisualStyleBackColor = true;
            btnMoDangKy.Click += btnMoDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 59);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "IP Server :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 59);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 8;
            label2.Text = "Cổng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 109);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 9;
            label3.Text = "Tên Đăng Nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 155);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 10;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(128, 56);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(100, 23);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(326, 56);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 2;
            txtPort.Text = "8386";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(128, 106);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(100, 23);
            txtTenDangNhap.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 155);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 11;
            label5.Text = "Mật Khẩu :";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(130, 155);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(100, 23);
            txtMatKhau.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Enabled = false;
            btnDangNhap.Location = new Point(309, 155);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(117, 35);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập ";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblLoi
            // 
            lblLoi.ForeColor = Color.Red;
            lblLoi.Location = new Point(12, 196);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(224, 55);
            lblLoi.TabIndex = 12;
            // 
            // btnKetNoi
            // 
            btnKetNoi.Location = new Point(326, 97);
            btnKetNoi.Name = "btnKetNoi";
            btnKetNoi.Size = new Size(100, 27);
            btnKetNoi.TabIndex = 3;
            btnKetNoi.Text = "Kết nối";
            btnKetNoi.UseVisualStyleBackColor = true;
            btnKetNoi.Click += btnKetNoi_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 260);
            Controls.Add(btnKetNoi);
            Controls.Add(lblLoi);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label5);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtPort);
            Controls.Add(txtIP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnMoDangKy);
            Controls.Add(lblGioiThieu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIP;
        private TextBox txtPort;
        private TextBox txtTenDangNhap;
        private Label label5;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private Label lblLoi;
        private Button btnKetNoi;
    }
}