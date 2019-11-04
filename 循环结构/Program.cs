using System;

namespace 循环结构
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            int i = n;
            while (i>0)
            {
                i--;
                Console.WriteLine("I'm while "+"i="+i);
            }
            i = n;
            //do-while循环特点：循环体至少执行一遍
            do
            {
                i--;
                Console.WriteLine("I'm do-while " + "i=" + i);
            } while (i != 0);

            for (i = n; i > 0; i--)
            {
                Console.WriteLine("I'm for " + "i=" + i);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
