using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap3
{
    public record GoiTin(
        string Loai,
        string hoTen = null,
        string IDND = null,
        string NguyenNhanLoi = null,
        string ThongBao = null,
        string username = null,
        string password = null,
        string email = null
    );
}
