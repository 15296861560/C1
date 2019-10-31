using System;

namespace 加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine(i++);//后加加，输出10
            Console.WriteLine(i);
            Console.WriteLine(++i);//先加加，输出12
            Console.WriteLine(i--);//后减减，输出12
            Console.WriteLine(i);
            Console.WriteLine(--i);//先减减，输出10
            Console.WriteLine("Hello World!");
        }
    }
}
