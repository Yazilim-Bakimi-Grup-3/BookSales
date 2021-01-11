using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YazilimBakimi.KitapSatisUygulamasi
{
    public class Cryptology
    {
        public static string MD5Sifrele(string Metin)
        {
            MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
            byte[] Bte = Encoding.UTF8.GetBytes(Metin);
            Bte = Md5.ComputeHash(Bte);

            StringBuilder Sb = new StringBuilder();

            foreach( byte Ba in Bte)
            {
                Sb.Append(Ba.ToString("x2").ToLower());
            }
            return Sb.ToString();
        }
    }
}
