using BaiTapChuong03;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
namespace BaiTap3
{
    public class Server
    {
        TcpClient _tcp = new TcpClient();

        private const string chuoiketNoi =
        "Server=localhost;Database=QuanLyNguoiDung;Integrated Security=True;TrustServerCertificate=True;";
        private readonly ConcurrentDictionary<string, StreamWriter> _danhsachClient = new();
        private readonly SemaphoreSlim _khoaDb = new(1, 1);
        private readonly SemaphoreSlim _khoaGui = new(1, 1);
        private async Task GuiCho1Client(StreamWriter _ghi, GoiTin pack)
        {
            string dong = JsonSerializer.Serialize(pack);
            await _khoaGui.WaitAsync();
            {
                try
                {
                    _ghi.WriteLineAsync(dong);
                }
                catch (IOException) { }
                finally
                {
                    _khoaGui.Release();
                }
            }
        }
        private async Task PhatAllClient(GoiTin pack)
        {
            foreach (var (id, ghi) in _danhsachClient)
            {
                GuiCho1Client(ghi, pack);
            }
        }

        private async Task<GoiTin> DangKy(GoiTin Pack)
        {
            using var cn = new SqlConnection(chuoiketNoi);
            await cn.OpenAsync();
            using (var CheckHoTen = new SqlCommand("SELECT COUNT(*) FROM NGUOIDUNG WHERE Username = @hoten", cn))
            {
                CheckHoTen.Parameters.Add("@hoten", SqlDbType.NVarChar, 50).Value = Pack.username;
                int soluong = (int)(await CheckHoTen.ExecuteScalarAsync());
                if (soluong > 0) return new GoiTin("LOI", NguyenNhanLoi: "Trung_Ho_Ten", ThongBao: "Tên đăng nhập đã tồn tại");
            }

            var (hash, salt) = BamMatKhau.Bam(Pack.password);
            using (var TaoNguoiDung = new SqlCommand("INSERT INTO NGUOIDUNG (Username, PasswordHash , PasswordSalt , Email" +
                "VALUES (@u , @pHash , @pSalt, @email", cn))
            {
                TaoNguoiDung.Parameters.Add("@u", SqlDbType.NVarChar, 50).Value = Pack.username;
                TaoNguoiDung.Parameters.Add("@pHash", SqlDbType.NVarChar, 50).Value = hash;
                TaoNguoiDung.Parameters.Add("@pSalt", SqlDbType.NVarChar, 50).Value = salt;
                TaoNguoiDung.Parameters.Add("@email", SqlDbType.NVarChar, 200).Value = Pack.email;
                await TaoNguoiDung.ExecuteNonQueryAsync();
            }
            return new GoiTin("OK", ThongBao: "Đăng ký thành công");
        }
        private async Task<GoiTin> DangNhap(GoiTin Pack)
        {
            using var cn = new SqlConnection(chuoiketNoi);
            await cn.OpenAsync();
            using (var checkUser = new SqlCommand("SELECT PasswordHash , PasswordSalt , username FORM NGUOIDUNG WHERE username = @u", cn))
            {
                checkUser.Parameters.Add("@u", SqlDbType.NVarChar, 200).Value = Pack.username;
                using var r = await checkUser.ExecuteReaderAsync();

                string hash = r.GetString(0);
                string salt = r.GetString(1);
                string username = r.GetString(2);

                if (!BamMatKhau.Kiem(Pack.password, hash, salt))
                {
                    return new GoiTin("LOI", NguyenNhanLoi: "SAI TK OR MK", ThongBao: "Sai tên đăng nhập hoặc mật khẩu!");
                }
                return new GoiTin("Success", ThongBao: "Đăng nhập thành công!", username: Pack.username);
            }
        }


        private async Task phucVuClient(TcpClient tcp)
        {
            string id = Guid.NewGuid().ToString();
            using (tcp)
            {
                StreamWriter _ghi = new StreamWriter(tcp.GetStream());
                StreamReader _doc = new StreamReader(tcp.GetStream());
                _danhsachClient[id] = _ghi;
                DateTime now = DateTime.Now;
                Console.WriteLine($" [{now}] , [{id}] vào -> Tổng cộng {_danhsachClient.Count} Client đang kết nối!");
                try
                {
                    await GuiCho1Client(_ghi, new GoiTin("ID:", IDND: id));
                    string yeucauClient;
                    while ((yeucauClient = await _doc.ReadLineAsync()) != null)
                    {
                        GoiTin yeucau = JsonSerializer.Deserialize<GoiTin>(yeucauClient);
                        if (yeucau.Loai == "DANGKY")
                        {
                            await GuiCho1Client(_ghi, await DangKy(yeucau));
                            continue;
                        }
                        if (yeucau.Loai == "DANGNHAP")
                        {
                            await GuiCho1Client(_ghi, await DangNhap(yeucau));
                            continue;
                        }
                        if (yeucau.Loai == "DANGXUAT")
                        {
                            _danhsachClient.TryRemove(id, out _);
                            Console.WriteLine($"[{id}] đã rời phòng ! Còn {_danhsachClient.Count}");
                            await GuiCho1Client(_ghi, new GoiTin("OK", ThongBao: "Đã rời đi !"));
                            return;
                        }
                    }
                }
                catch (IOException) { }
                catch (SqlException) { }
                catch (SocketException) { }
                finally
                {
                    _danhsachClient.TryRemove(id, out _);
                    Console.WriteLine($"[{id}] đã rời phòng ! Còn {_danhsachClient.Count}");
                }
            }
        }

        public async Task ChayAsync()
        {
            var tcplistener = new TcpListener(IPAddress.Any, 8386);
            tcplistener.Start();
            try
            {
                while (true)
                {
                    TcpClient tcp = await tcplistener.AcceptTcpClientAsync();
                    _ = phucVuClient(tcp);
                }
            }
            finally
            {
                tcplistener.Stop();
            }
        }
    }
}
