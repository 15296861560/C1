using System;
using System.IO;
using System.Text;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Create(@"D:\Test\c#\lgy.txt");//创建文件（如果该路径下有同名同类型文件将会删除原文件再创建）
            //File.Delete(@"D:\Test\c#\new.txt");//删除指定目录下的指定文件
            //File.Copy(@"D:\Test\c#\lgy.txt", @"D:\Test\c#\new.txt");//将指定目录下的指定文件复制到新位置，并使用新名称

            byte[] buffer = File.ReadAllBytes(@"D:\Test\c#\lgy.txt");//以字节为单位读取文件并存入字节数组

            string s = Encoding.Default.GetString(buffer);//将字节数组中的每一个元素都要按照我们指定的编码格式解码成字符串

            byte[] buf = Encoding.Default.GetBytes("谔谔阿德撒大大大苏打的");//将字符串转换成字节数组
            File.WriteAllBytes(@"D:\Test\c#\new.txt", buf);//将字符串写入指定文件，并覆盖该文件的原本内容

            Console.WriteLine(s);
        }
    }
}
