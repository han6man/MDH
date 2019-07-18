using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Strings
{
    public static class Encodings
    {

        public static string DecodeFromUTF8(string str)
        {
            Encoding encoding = Encoding.UTF8;
            char[] chars = str.ToCharArray();
            byte[] srcBytes = encoding.GetBytes(chars);
            byte[] dstBytes = Encoding.Convert(encoding, Encoding.GetEncoding("Windows-1251"), srcBytes);

            str = encoding.GetString(dstBytes);
            return encoding.GetString(dstBytes);
        }

        public static string EncodeToUTF8(string str)
        {
            Encoding encoding = Encoding.GetEncoding("Windows-1251");
            char[] chars = str.ToCharArray();
            byte[] srcBytes = encoding.GetBytes(chars);
            byte[] dstBytes = Encoding.Convert(encoding, Encoding.UTF8, srcBytes);

            str = encoding.GetString(dstBytes);
            return str;
        }
    }
}
