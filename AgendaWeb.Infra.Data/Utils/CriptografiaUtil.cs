using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Utils
{
    public class CriptografiaUtil
    {
        public static string GetMD5(string valor)
        {
            var hash = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(valor));

            var result = string.Empty;
            foreach (var item in hash)
            {
                result += item.ToString("X2"); //Hexadecimal
            }

            return result;
        }
    }
}
