using System;

namespace 控制台输出文本颜色
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;//控制台背景色
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Red;//接下来输出的文本颜色
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
        }
    }
}
