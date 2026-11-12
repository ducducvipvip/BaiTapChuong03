using System.Security.Cryptography;

namespace BaiTap3
{
    public static class BamMatKhau
    {
        private const int SoVong = 100000;
        private const int DoDaiHash = 32;
        public static (string Hash, string Salt) Bam(string matKhau)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(matKhau, salt, SoVong, HashAlgorithmName.SHA256, DoDaiHash);
            return (Convert.ToBase64String(hash), Convert.ToBase64String(salt));
        }

        public static bool Kiem(string matKhau, string hashLuu, string saltLuu)
        {
            byte[] salt = Convert.FromBase64String(saltLuu);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(matKhau, salt, SoVong, HashAlgorithmName.SHA256, DoDaiHash);
            return CryptographicOperations.FixedTimeEquals(hash, Convert.FromBase64String(hashLuu));
        }
    }
}