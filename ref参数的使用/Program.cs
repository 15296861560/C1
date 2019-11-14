using System;

namespace ref参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {

            //ref参数能够将一个变量带入方法中进行改变，改变完成后再将改变后的值带出方法
            //ref参数要求方法外必须为其赋值，而方法内可以不赋值
            int s = 0;
            S(ref s);

            Console.WriteLine(s);
        }

        public static void S(ref int s)
        {
            s++;
        }
    }
}
