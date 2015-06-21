namespace Library
{
    using System;
    using System.Globalization;
    using System.Security.Cryptography;
    using System.Text;
    using System.Web.Security;

    public class SecurityHelper
    {
        private static string _sKey = GenerateKey();

        public static string DecryptString(string string_0)
        {
            string[] strArray = string_0.Split("-".ToCharArray());
            byte[] inputBuffer = new byte[strArray.Length];
            for (int i = 0; i < strArray.Length; i++)
            {
                inputBuffer[i] = byte.Parse(strArray[i], NumberStyles.HexNumber);
            }
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider {
                Key = Encoding.ASCII.GetBytes(_sKey),
                IV = Encoding.ASCII.GetBytes(_sKey)
            };
            byte[] bytes = provider.CreateDecryptor().TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string EncryptMD5String(string string_0)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(string_0, "MD5");
        }

        public static string EncryptString(string string_0)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(string_0);
            DESCryptoServiceProvider provider = new DESCryptoServiceProvider {
                Key = Encoding.ASCII.GetBytes(_sKey),
                IV = Encoding.ASCII.GetBytes(_sKey)
            };
            return BitConverter.ToString(provider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
        }

        private static string GenerateKey()
        {
            string str = string.Empty;
            DESCryptoServiceProvider provider = (DESCryptoServiceProvider) DES.Create();
            str = Encoding.ASCII.GetString(provider.Key);
            while (str.Length > 0)
            {
                if (str.IndexOf('|') == -1)
                {
                    return str;
                }
                str = Encoding.ASCII.GetString(provider.Key);
            }
            return str;
        }

        public static string Key
        {
            get
            {
                return _sKey;
            }
        }
    }
}

