using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");

            Console.WriteLine(s);
        }

        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //将字符串传换为字节数组
            byte[] buffer = Encoding.Default.GetBytes(str);
            //开始加密,返回一个加密好的字节数组
            byte[] MD5Buffer= md5.ComputeHash(buffer);

            //字节数组--》字符串
            //1.将字节数组中的每个元素按照指定的编码格式解析成字符串
            //2.直接将数组ToString（）
            //将字节数组中的每个元素ToString（）

            //将字节数组转化为字符串(将字节数组中的每个元素ToString（）)
            string result = null;
            foreach (byte b in MD5Buffer)
            {
                result += b.ToString("x2");//以16进制转换成字符串，每次都是两位数
            }

            return result;
        }
    }
}
