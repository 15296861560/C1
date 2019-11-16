using System;

namespace 方法的递归
{
    class Program
    {
        //方法的递归就是方法自己调用自己
        static void Main(string[] args)
        {
            Console.WriteLine(recursion(-4));
            Console.WriteLine(recursion(2));
        }

        public static int recursion(int x)
        {
            x++;
            if (x < 0) return recursion(x);
            else return x ;
        }
    }
}
