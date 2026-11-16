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
            lblGioiThieu.Location = new Point(186, 15);
            lblGioiThieu.Margin = new Padding(4, 0, 4, 0);
            lblGioiThieu.Name = "lblGioiThieu";
            lblGioiThieu.Size = new Size(288, 38);
            lblGioiThieu.TabIndex = 0;
            lblGioiThieu.Text = "Đăng nhập hệ thống";
            // 
            // btnMoDangKy
            // 
            btnMoDangKy.BackColor = SystemColors.HotTrack;
            btnMoDangKy.ForeColor = SystemColors.ButtonHighlight;
            btnMoDangKy.Location = new Point(464, 249);
            btnMoDangKy.Margin = new Padding(4, 5, 4, 5);
            btnMoDangKy.Name = "btnMoDangKy";
            btnMoDangKy.Size = new Size(167, 42);
            btnMoDangKy.TabIndex = 6;
            btnMoDangKy.Text = "Đăng ký tài khoản";
            btnMoDangKy.UseVisualStyleBackColor = false;
            btnMoDangKy.Click += btnMoDangKy_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 99);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 7;
            label1.Text = "IP Server :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 102);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 8;
            label2.Text = "Cổng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 25);
            label3.TabIndex = 9;
            label3.Text = "Tên Đăng Nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 258);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 10;
            // 
            // txtIP
            // 
            txtIP.Location = new Point(115, 96);
            txtIP.Margin = new Padding(4, 5, 4, 5);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(141, 31);
            txtIP.TabIndex = 1;
            txtIP.Text = "127.0.0.1";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(345, 96);
            txtPort.Margin = new Padding(4, 5, 4, 5);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(73, 31);
            txtPort.TabIndex = 2;
            txtPort.Text = "8386";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(183, 177);
            txtTenDangNhap.Margin = new Padding(4, 5, 4, 5);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(141, 31);
            txtTenDangNhap.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 258);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(96, 25);
            label5.TabIndex = 11;
            label5.Text = "Mật Khẩu :";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(186, 258);
            txtMatKhau.Margin = new Padding(4, 5, 4, 5);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(141, 31);
            txtMatKhau.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.HotTrack;
            btnDangNhap.Enabled = false;
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(464, 170);
            btnDangNhap.Margin = new Padding(4, 5, 4, 5);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(167, 38);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng Nhập ";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lblLoi
            // 
            lblLoi.ForeColor = Color.Red;
            lblLoi.Location = new Point(17, 327);
            lblLoi.Margin = new Padding(4, 0, 4, 0);
            lblLoi.Name = "lblLoi";
            lblLoi.Size = new Size(320, 92);
            lblLoi.TabIndex = 12;
            lblLoi.Click += lblLoi_Click_1;
            // 
            // btnKetNoi
            // 
            btnKetNoi.BackColor = SystemColors.HotTrack;
            btnKetNoi.ForeColor = SystemColors.ButtonHighlight;
            btnKetNoi.Location = new Point(464, 96);
            btnKetNoi.Margin = new Padding(4, 5, 4, 5);
            btnKetNoi.Name = "btnKetNoi";
            btnKetNoi.Size = new Size(127, 39);
            btnKetNoi.TabIndex = 3;
            btnKetNoi.Text = "Kết nối";
            btnKetNoi.UseVisualStyleBackColor = false;
            btnKetNoi.Click += btnKetNoi_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btnDangNhap;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 433);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosed += LoginForm_FormClosed;
            Load += LoginForm_Load;
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