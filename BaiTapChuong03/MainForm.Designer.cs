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
            lblWelcome.Location = new Point(15, 27);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(207, 25);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Xin chào, Nguyễn Văn A!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 150);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 2;
            label3.Text = "Email         :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 3;
            label2.Text = "Họ và tên     :";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(266, 94);
            lblHoTen.Margin = new Padding(4, 0, 4, 0);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(125, 25);
            lblHoTen.TabIndex = 4;
            lblHoTen.Text = "Nguyễn Văn A";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(266, 150);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(115, 25);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "a@uit.edu.vn";
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(15, 308);
            lblTrangThai.Margin = new Padding(4, 0, 4, 0);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(173, 25);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Đã kết nối tới Server";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(266, 46);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 25);
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
            grpThongTin.Location = new Point(15, 79);
            grpThongTin.Margin = new Padding(4, 4, 4, 4);
            grpThongTin.Name = "grpThongTin";
            grpThongTin.Padding = new Padding(4, 4, 4, 4);
            grpThongTin.Size = new Size(740, 192);
            grpThongTin.TabIndex = 8;
            grpThongTin.TabStop = false;
            grpThongTin.Text = "Thông tin tài khoản";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(614, 295);
            btnDangXuat.Margin = new Padding(4, 4, 4, 4);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(141, 71);
            btnDangXuat.TabIndex = 9;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 380);
            Controls.Add(btnDangXuat);
            Controls.Add(lblWelcome);
            Controls.Add(grpThongTin);
            Controls.Add(lblTrangThai);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
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