using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using BaiTap3;

namespace BaiTapChuong03
{
    public partial class LoginForm : Form
    {
        private TcpClient? _client;
        private StreamReader? _reader;
        private StreamWriter? _writer;
        private bool _daKetNoi = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnKetNoi_Click(object sender, EventArgs e)
        {
            lblLoi.ForeColor = Color.Red;
            lblLoi.Text = "";

            string ip = txtIP.Text.Trim();
            string portText = txtPort.Text.Trim();

            if (string.IsNullOrEmpty(ip) || !int.TryParse(portText, out int port))
            {
                lblLoi.Text = "Vui lòng nhập đúng IP và cổng Server.";
                return;
            }

            btnKetNoi.Enabled = false;
            try
            {
                DongKetNoi();

                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);

                var stream = _client.GetStream();
                _reader = new StreamReader(stream, Encoding.UTF8);
                _writer = new StreamWriter(stream, new UTF8Encoding(false)) { AutoFlush = true };

                // Đọc gói tin "ID:" mặc định Server gửi ngay khi Client kết nối
                string? goiTinChao = await _reader.ReadLineAsync();
                if (string.IsNullOrEmpty(goiTinChao))
                {
                    lblLoi.Text = "Server không phản hồi.";
                    DongKetNoi();
                    btnKetNoi.Enabled = true;
                    return;
                }

                _daKetNoi = true;
                lblLoi.ForeColor = Color.Green;
                lblLoi.Text = $"Đã kết nối Server ({ip}:{port})";

                txtIP.Enabled = false;
                txtPort.Enabled = false;
                btnKetNoi.Text = "Đã kết nối";
                btnDangNhap.Enabled = true;
                txtTenDangNhap.Focus();
            }
            catch (SocketException)
            {
                lblLoi.Text = "Không thể kết nối tới Server.";
                btnKetNoi.Enabled = true;
                DongKetNoi();
            }
            catch (Exception)
            {
                lblLoi.Text = "Lỗi kết nối mạng.";
                btnKetNoi.Enabled = true;
                DongKetNoi();
            }
        }

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            lblLoi.ForeColor = Color.Red;
            lblLoi.Text = "";

            if (!_daKetNoi || _client == null || !_client.Connected || _reader == null || _writer == null)
            {
                lblLoi.Text = "Vui lòng bấm Kết nối trước khi đăng nhập.";
                DatLaiTrangThaiKetNoi();
                return;
            }

            string username = txtTenDangNhap.Text.Trim();
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblLoi.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.";
                return;
            }

            btnDangNhap.Enabled = false;
            try
            {
                var yeuCau = new GoiTin(Loai: "DANGNHAP", username: username, password: password);
                await _writer.WriteLineAsync(JsonSerializer.Serialize(yeuCau));

                string? phanHoiJson = await _reader.ReadLineAsync();
                if (string.IsNullOrEmpty(phanHoiJson))
                {
                    lblLoi.Text = "Server ngắt kết nối đột ngột.";
                    DatLaiTrangThaiKetNoi();
                    return;
                }

                var phanHoi = JsonSerializer.Deserialize<GoiTin>(phanHoiJson);
                if (phanHoi != null && phanHoi.Loai == "Success")
                {
                    MainForm mainForm = new MainForm(phanHoi, _client, _reader, _writer);
                    this.Hide();
                    mainForm.ShowDialog();

                    DatLaiTrangThaiKetNoi();
                    txtMatKhau.Clear();
                    this.Show();
                }
                else
                {
                    lblLoi.Text = phanHoi?.ThongBao ?? "Tên đăng nhập hoặc mật khẩu không đúng!";
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                    btnDangNhap.Enabled = true;
                }
            }
            catch (IOException)
            {
                lblLoi.Text = "Lỗi đường truyền mạng.";
                DatLaiTrangThaiKetNoi();
            }
            catch (Exception)
            {
                lblLoi.Text = "Đã xảy ra lỗi không xác định.";
                btnDangNhap.Enabled = true;
            }
        }

        private void btnMoDangKy_Click(object sender, EventArgs e)
        {
            using var registerForm = new RegisterForm();
            registerForm.ShowDialog(this);
        }

        private void DongKetNoi()
        {
            _daKetNoi = false;
            try { _reader?.Dispose(); } catch { }
            try { _writer?.Dispose(); } catch { }
            try { _client?.Close(); } catch { }
            _reader = null;
            _writer = null;
            _client = null;
        }

        private void DatLaiTrangThaiKetNoi()
        {
            DongKetNoi();
            txtIP.Enabled = true;
            txtPort.Enabled = true;
            btnKetNoi.Text = "Kết nối";
            btnKetNoi.Enabled = true;
            btnDangNhap.Enabled = false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            DongKetNoi();
            base.OnFormClosing(e);
        }
    }
}