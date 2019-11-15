using System;

namespace 方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的重载就是方法的名称相同，但是参数不同
            //方法的重载与返回值没有关系
            //参数不同的两种情况：
            //1.参数的个数相同，那么参数的类型就不能相同
            //2.如果参数的类型相同，那么参数的个数就不能相同

            int l = 222;
            string s = "333";
            XXX();
            XXX(l);
            XXX(l,9);
            Console.WriteLine(XXX(s));
        }


        public static void XXX()
        {
            Console.WriteLine("X1");
        }

        public static void XXX(int l)
        {
            Console.WriteLine("X1"+l);
        }

        public static void XXX(int l,int l2)
        {
            Console.WriteLine("X1" + l+l2);
        }

        public static string XXX(string l)
        {
           return "X1" + l;
        }

    }
}
