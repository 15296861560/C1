using System;
using System.IO;

namespace Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"D:\Test\c#\lgy.txt";

            int index = str.LastIndexOf("\\");
            string fileName = str.Substring(index+1);

            string fileName2 =Path.GetFileName(str);//获取文件名
            string fileName3 =Path.GetFileNameWithoutExtension(str);//获取文件名但是不包含扩展名
            string fileName4 =Path.GetExtension(str);//获取文件扩展名
            string path1 =Path.GetDirectoryName(str);//获取文件夹路径
            string path2 =Path.GetFullPath(str);//获取文件所在的全路径
            string path3 =Path.Combine(@"D:\a\","b.txt");//连接两个字符串作为路径

            Console.WriteLine(fileName);
            Console.WriteLine(fileName2);
            Console.WriteLine(fileName3);
            Console.WriteLine(fileName4);
            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.WriteLine(path3);
        }
    }
}
