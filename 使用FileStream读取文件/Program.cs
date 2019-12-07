using System;
using System.IO;
using System.Text;

namespace 使用FileStream读取文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream ：操作字节的

            //使用FileStream读取数据
            string path = @"D:\Test\c#\lgy.txt";
            FileStream fileStream = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024*5];
            int r=fileStream.Read(buffer, 0, buffer.Length);//返回本次读取到的有效字节数
            string s = Encoding.Default.GetString(buffer,0,r);//将字节数组中从0到r字节按照指定的编码格式解码成字符串
            fileStream.Close();//关闭流
            fileStream.Dispose();//释放流所占用的资源
            Console.WriteLine(s);

            //使用FileStream写入数据
            using (FileStream fsw = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "这是新写入";
                byte[] bw = Encoding.Default.GetBytes(str);
                fsw.Write(bw, 0, bw.Length);

            }
            string sn = File.ReadAllText(path, Encoding.Default);
            Console.WriteLine("-------------\n" + sn);

            //StreamReader和StreamWriter ：操作字符的


        }
    }
}
