using System;
using sms.dal.Data;
using sms.dal.Models;
using sms.dal.Repositories;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sms.bll
{
    public class UserService
    {

        public static string HashPassword(string password)
        {
            SHA256 hash = SHA256.Create();

            byte[] passBytes = Encoding.Default.GetBytes(password);

            string hashedPass = Convert.ToHexString(hash.ComputeHash(passBytes));

            return hashedPass;
        }
    }
}
