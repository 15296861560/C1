using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 40;
            double y = 40.0;
            decimal z = 40m;
            char k = '4';
            String l = "40";
            string ll = "40";

            #region
            /**
            Console.WriteLine(l == ll);
            Console.WriteLine(x == y);
            Console.WriteLine(x == z);
            **/
            #endregion
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(k);
            Console.WriteLine(l.Equals(ll));
            Console.WriteLine(l==ll);
            Console.WriteLine(x==y);
            Console.WriteLine(x==z);
            Console.WriteLine("int x={0},double y={1},decimal z={2},char k={3},string ll={4}", x, y, z, k, ll);
            int a = 111,b = 222;
            a = a - b;
            b = a+b;
            a = b - a;
            Console.WriteLine("a={0},b={1}",a,b);
            Console.ReadKey();//暂停程序

        }
    }
}
