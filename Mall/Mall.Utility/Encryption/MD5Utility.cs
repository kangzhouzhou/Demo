using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Mall.Utility.Encryption
{
    public class MD5Utility
    {
        /// <summary>
        /// 字符串MD5加密，返回32位大写字母
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文（大写字母）</returns>
        public static string Encrypt32UpCase(string plainText)
        {
            MD5 md = MD5.Create();
            byte[] b = md.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            var s = new StringBuilder(32);
            for (int i = 0; i < b.Length; i++)
            {
                s.AppendFormat("{0:X2}", b[i]);
            }
            return s.ToString();
        }

        /// <summary>
        /// 字符串MD5加密，返回32位大写字母
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文（大写字母）</returns>
        public static string Encrypt32LowerCase(string plainText)
        {
            MD5 md = MD5.Create();
            byte[] b = md.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            var s = new StringBuilder(32);
            for (int i = 0; i < b.Length; i++)
            {
                s.AppendFormat("{0:x2}", b[i]);
            }
            return s.ToString();
        }

        /// <summary>
        /// 字符串MD5加密，返回16位大写字母
        /// </summary>
        /// <param name="plainText">明文</param>
        /// <returns>密文（大写字母）</returns>
        public static string Encrypt16UpCase(string plainText)
        {
            MD5 md = MD5.Create();
            byte[] b = md.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            var s = new StringBuilder(16);
            for (int i = 4; i < 12; i++)
            {
                s.AppendFormat("{0:X2}", b[i]);
            }
            return s.ToString();
        }

        public static string Encrypt16LowerCase(string plainText)
        {
            MD5 md = MD5.Create();
            byte[] b = md.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            var s = new StringBuilder(16);
            for (int i = 4; i < 12; i++)
            {
                s.AppendFormat("{0:X2}", b[i]);
            }
            return s.ToString();
        }
    }
}
