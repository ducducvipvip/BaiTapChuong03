namespace BaiTapChuong03
{
    partial class MainForm
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
            lblWelcome = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblHoTen = new Label();
            lblEmail = new Label();
            lblTrangThai = new Label();
            lblUsername = new Label();
            grpThongTin = new GroupBox();
            btnDangXuat = new Button();
            grpThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(12, 28);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(170, 20);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xin chào, Nguyễn Văn A!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 37);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 120);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Email         :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 83);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên     :";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(213, 83);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(102, 20);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Nguyễn Văn A";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(213, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(94, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "a@uit.edu.vn";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(12, 236);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(144, 20);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Đã kết nối tới Server";
           
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(213, 37);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(88, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "nguyenvana";
            // 
            // grpThongTin
            // 
            grpThongTin.Controls.Add(label1);
            grpThongTin.Controls.Add(label2);
            grpThongTin.Controls.Add(lblUsername);
            grpThongTin.Controls.Add(lblEmail);
            grpThongTin.Controls.Add(label3);
            grpThongTin.Controls.Add(lblHoTen);
            grpThongTin.Location = new Point(12, 63);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Size = new Size(592, 154);
            grpThongTin.TabIndex = 8;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin tài khoản";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(491, 236);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(113, 57);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 304);
            Controls.Add(btnDangXuat);
            Controls.Add(lblWelcome);
            Controls.Add(grpThongTin);
            Controls.Add(lblTrangThai);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin người dùng";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            grpThongTin.ResumeLayout(false);
            grpThongTin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblHoTen;
        private Label lblEmail;
        private Label lblTrangThai;
        private Label lblUsername;
        private GroupBox grpThongTin;
        private Button btnDangXuat;
    }
}