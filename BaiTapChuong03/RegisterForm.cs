using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using BaiTap3;

namespace BaiTapChuong03
{
    public partial class RegisterForm : Form
    {
        private readonly StreamWriter ghi;
        private readonly StreamReader doc;
        public RegisterForm(StreamWriter ghi, StreamReader doc)
        {
            InitializeComponent();
            this.ghi = ghi;
            this.doc = doc;
        }

        private async void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.SelectAll();
                txtConfirmPassword.Focus();
                return;
            }

            if (!LaEmailHopLe(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập email đúng định dạng.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            string serverIP = txtServerIP.Text.Trim();
            if (string.IsNullOrWhiteSpace(serverIP) || !IPAddress.TryParse(serverIP, out IPAddress? ipAddress))
            {
                labelTrangThai.Text = "Lỗi kết nối";
                MessageBox.Show("Địa chỉ IP Server không hợp lệ.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServerIP.Focus();
                return;
            }

            if (!int.TryParse(txtServerPort.Text.Trim(), out int serverPort) ||
                serverPort < 1024 || serverPort > 49151)
            {
                labelTrangThai.Text = "Lỗi kết nối";
                MessageBox.Show("Cổng Server phải là số nguyên từ 1024 đến 49151.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServerPort.Focus();
                return;
            }

            btnDangKy.Enabled = false;
            labelTrangThai.Text = "Đang kết nối...";
            try { 
                var yeuCau = new GoiTin("DANGKY", hoTen: txtFullName.Text.Trim(), username: txtUsername.Text.Trim(), password: txtPassword.Text, email: txtEmail.Text.Trim());
                await ghi.WriteLineAsync(JsonSerializer.Serialize(yeuCau));
                string? dongPhanHoi = await doc.ReadLineAsync();
                if (string.IsNullOrWhiteSpace(dongPhanHoi))
                {
                    throw new IOException();
                }

                GoiTin? phanHoi = JsonSerializer.Deserialize<GoiTin>(dongPhanHoi);
                if (phanHoi == null)
                {
                    throw new IOException();
                }

                if (phanHoi.Loai.Equals("OK", StringComparison.OrdinalIgnoreCase))
                {
                    labelTrangThai.Text = "Đăng ký thành công";
                    MessageBox.Show(phanHoi.ThongBao ?? "Đăng ký thành công.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    labelTrangThai.Text = "Đăng ký thất bại";
                    MessageBox.Show(phanHoi.ThongBao ?? "Đăng ký thất bại.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SocketException)
            {
                labelTrangThai.Text = "Lỗi kết nối";
                MessageBox.Show("Không thể kết nối đến máy chủ. Vui lòng kiểm tra Server đang hoạt động.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                labelTrangThai.Text = "Lỗi kết nối";
                MessageBox.Show("Kết nối đến máy chủ bị gián đoạn. Vui lòng thử lại.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException)
            {
                labelTrangThai.Text = "Lỗi kết nối";
                MessageBox.Show("Máy chủ trả về dữ liệu không hợp lệ. Vui lòng thử lại.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDangKy.Enabled = true;
            }
        }

        private static bool LaEmailHopLe(string email)
        {
            try
            {
                var diaChi = new MailAddress(email);
                return diaChi.Address == email && email.Contains('@');
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void labelTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}
