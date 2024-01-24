using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Security.Cryptography;

namespace TestWPF.Model
{
    public class SignInModel
    {
        public Account GetUserFromDB(string login, string password)
        {
            var User = DataBase.db.Account.FirstOrDefault(u => u.Login == login && u.Password == password);
            return User;
        }

        //private string HexDigest(byte[] data)
        //{
        //    var sBuilder = new StringBuilder();
        //    for (var i = 0; i < data.Length; i++)
        //        sBuilder.Append(data[i].ToString("x2"));
        //    return sBuilder.ToString();
        //}

        //private bool CheckAccount(string password, Account account)
        //{
        //    string hash = string.Empty;
        //    using (var sha256Hash = SHA256.Create())
        //    {
        //        var data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
        //        hash = HexDigest(data);
        //        data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(String.Concat(hash, account.Salt)));
        //        hash = HexDigest(data);
        //    }
        //    return hash == account.HashSaltPassword;
        //}
    }
}
