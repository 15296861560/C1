using System;
using System.IO;
using System.Text;

namespace StreamReader和StreamWriter的使用
{
    class Program
    {
        //StreamReader和StreamWriter ：操作字符的

        static void Main(string[] args)
        {

            string path = @"D:\Test\c#\lgy.txt";
            //使用StreamReader读取文件
            using (StreamReader sr = new StreamReader(path,Encoding.Default))
            {
                while (!sr.EndOfStream)//是否读到了文件的结尾
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            //使用StreamWriter来写入一个文本文件
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                sw.Write("哈哈哈小孩子上学了！");
            }


            Console.WriteLine("Hello World!");
        }
    }
}
