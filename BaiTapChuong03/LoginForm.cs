using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BaiTap3;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;

namespace BaiTapChuong03
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnMoDangKy_Click(object sender, EventArgs e)
        {
            using var registerForm = new RegisterForm();
            registerForm.ShowDialog(this);
        }

        private void lblGioiThieu_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblLoi.Text = "";
            string ip = txtIP.Text.Trim();
            string portText = txtPort.Text.Trim();
            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            // Kiểm tra dữ liệu trống trước khi gửi qua mạng
            if (string.IsNullOrEmpty(ip) || !int.TryParse(portText, out int port))
            {
                lblLoi.Text = "Vui lòng nhập đúng IP và cổng Server.";
                return;
            }
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return;
            }

            // Khóa nút trong lúc chờ Server phản hồi để tránh bấm nhiều lần
            btnDangNhap.Enabled = false;
            try
            {
                using TcpClient client = new TcpClient();
                await client.ConnectAsync(ip, port);

                using var stream = client.GetStream();
                using var reader = new StreamReader(stream, Encoding.UTF8);
                using var writer = new StreamWriter(stream, new UTF8Encoding(false)) { AutoFlush = true };

                // Đọc bỏ qua gói tin "ID:" mặc định Server gửi ngay khi Client kết nối
                await reader.ReadLineAsync();

                // Đóng gói và gửi yêu cầu đăng nhập
                var yeuCau = new GoiTin(Loai: "DANGNHAP", username: username, password: password);
                await writer.WriteLineAsync(JsonSerializer.Serialize(yeuCau));

                // Nhận phản hồi từ Server
                string? phanHoiJson = await reader.ReadLineAsync();
                if (string.IsNullOrEmpty(phanHoiJson))
                {
                    lblLoi.Text = "Server ngắt kết nối đột ngột.";
                    return;
                }

                var phanHoi = JsonSerializer.Deserialize<GoiTin>(phanHoiJson);
                if (phanHoi != null && phanHoi.Loai == "Success")
                {
                    // Đăng nhập thành công -> Mở Form chính
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                    txtMatKhau.Clear();
                }
                else
                {
                    // Đăng nhập thất bại -> Hiện thông báo chung & xóa trắng ô mật khẩu
                    lblLoi.Text = phanHoi?.ThongBao ?? "Tên đăng nhập hoặc mật khẩu không đúng!";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
            catch (SocketException)
            {
                lblLoi.Text = "Không thể kết nối tới Server.";
            }
            catch (IOException)
            {
                lblLoi.Text = "Lỗi đường truyền mạng.";
            }
            catch (Exception)
            {
                lblLoi.Text = "Đã xảy ra lỗi không xác định.";
            }
            finally
            {
                btnDangNhap.Enabled = true;
            }
        }
    }
}
