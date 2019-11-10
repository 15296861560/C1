using System;

namespace 常量
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            num = 2;//变量可以被重新赋值
            const int cnum = 1;//常量不能被重新赋值

            Console.WriteLine("Hello World!");
        }
    }
}
