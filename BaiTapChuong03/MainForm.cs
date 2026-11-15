using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;
using System.Windows.Forms;
using BaiTap3; 

namespace BaiTapChuong03
{
    public partial class MainForm : Form
    {
        private readonly GoiTin? _thongTinUser;
        private readonly TcpClient? _client;
        private readonly StreamReader? _reader;
        private readonly StreamWriter? _writer;
        private bool _daDongKetNoi = false;

        
        public MainForm()
        {
            InitializeComponent();
        }

        
        public MainForm(GoiTin thongTinUser, TcpClient client, StreamReader reader, StreamWriter writer)
        {
            InitializeComponent();
            _thongTinUser = thongTinUser;
            _client = client;
            _reader = reader;
            _writer = writer;
        }

        
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_thongTinUser != null)
            {
                string tenHienThi = string.IsNullOrWhiteSpace(_thongTinUser.hoTen)
                    ? (_thongTinUser.username ?? "Người dùng")
                    : _thongTinUser.hoTen;

                lblWelcome.Text = $"Xin chào, {tenHienThi}!";
                lblUsername.Text = _thongTinUser.username ?? "(Không có)";
                lblHoTen.Text = string.IsNullOrWhiteSpace(_thongTinUser.hoTen) ? "(Chưa cập nhật)" : _thongTinUser.hoTen;
                lblEmail.Text = string.IsNullOrWhiteSpace(_thongTinUser.email) ? "(Chưa cập nhật)" : _thongTinUser.email;
            }

            if (_client != null && _client.Connected)
            {
                lblTrangThai.Text = "● Đã kết nối tới Server";
                lblTrangThai.ForeColor = Color.ForestGreen;
            }
        }

        
        private async void btnDangXuat_Click(object sender, EventArgs e)
        {
            
            btnDangXuat.Enabled = false;
            btnDangXuat.Text = "Đang xuất...";
            lblTrangThai.Text = "● Đang ngắt kết nối...";
            lblTrangThai.ForeColor = Color.DarkOrange;

            try
            {
                if (_client != null && _client.Connected && _writer != null)
                {
                    var goiTinDangXuat = new GoiTin(
                        Loai: "DANGXUAT",
                        username: _thongTinUser?.username
                    );

                    await _writer.WriteLineAsync(JsonSerializer.Serialize(goiTinDangXuat));

                    if (_reader != null)
                    {
                        await _reader.ReadLineAsync();
                    }
                }
            }
            catch (SocketException)
            {
                
            }
            catch (IOException)
            {
                
            }
            finally
            {
                DongKetNoiAnToan();
                this.Close();
            }
        }

        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DongKetNoiAnToan();
        }

        
        private void DongKetNoiAnToan()
        {
            if (_daDongKetNoi) return;
            _daDongKetNoi = true;

            try
            {
                _writer?.Dispose();
                _reader?.Dispose();
                _client?.Close();
                _client?.Dispose();
            }
            catch
            {
                
            }
        }
    }
}