using System;

namespace 转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\nWorld!");
            Console.WriteLine("Hello\r\nWorld!");
            Console.WriteLine(@"Hello\r\nWorld!");//@取消\的转义效果
            Console.WriteLine(@"Hello\
r\nWorld!");//@保留原格式输出
            
            int a = 10;
            double b = 11.1;
            int c;
            c = (int)b;
            b = a;
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
