namespace PublicClass
{
    using System;
    using System.Security.Cryptography;
    using System.Text;

    public class SecurityHelper
    {
        public static string EncryptString(string sInputString)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(sInputString);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
            provider.Key = Encoding.ASCII.GetBytes(Variable.sSecurityKey);
            provider.IV = Encoding.ASCII.GetBytes(Variable.sSecurityKey);
            return BitConverter.ToString(provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
        }
    }
}

