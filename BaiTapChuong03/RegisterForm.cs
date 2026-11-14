using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public RegisterForm()
        {
            InitializeComponent();
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

            btnDangKy.Enabled = false;
            try
            {
                using var tcpClient = new TcpClient();
                await tcpClient.ConnectAsync("localhost", 8386);

                using NetworkStream networkStream = tcpClient.GetStream();
                using var doc = new StreamReader(networkStream, Encoding.UTF8, true, 1024, true);
                using var ghi = new StreamWriter(networkStream, new UTF8Encoding(false), 1024, true)
                {
                    AutoFlush = true
                };

                string? goiTinChao = await doc.ReadLineAsync();
                if (string.IsNullOrWhiteSpace(goiTinChao))
                {
                    throw new IOException();
                }

                var yeuCau = new GoiTin(
                    "DANGKY",
                    hoTen: txtFullName.Text.Trim(),
                    username: txtUsername.Text.Trim(),
                    password: txtPassword.Text,
                    email: txtEmail.Text.Trim(),
                    birthday: dtpBirthday.Value.ToString("yyyy-MM-dd"));

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
                    MessageBox.Show(phanHoi.ThongBao ?? "Đăng ký thành công.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(phanHoi.ThongBao ?? "Đăng ký thất bại.", "Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Không thể kết nối đến máy chủ. Vui lòng kiểm tra Server đang hoạt động.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IOException)
            {
                MessageBox.Show("Kết nối đến máy chủ bị gián đoạn. Vui lòng thử lại.", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonException)
            {
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
    }
}
