using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1.Business_Layer
{
    class Encryptioncs
    {
        public static string Encrypt(string password)
        {
            char[] pass = password.ToCharArray();
            string[] Sysb = { "*", "*", "%", "&", "@" };
            string New_pass = "";
            Random RD = new Random();

            for (int i = pass.Length - 1; i >= 0; i--)
            {
                New_pass += ((int)pass[i]).ToString() + Sysb[RD.Next(0, 5)];
            }
            return New_pass;
        }

        public static string Decrypt(string password)
        {
            string[] tokens = password.Split('*', '*', '%', '&', '@');
            string pass = "";

            for (int i = tokens.Length - 2; i >= 0; i--)
            {
                pass += ((char)Convert.ToInt32(tokens[i])).ToString();
            }
            return pass;
        }
    }
}
