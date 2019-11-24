using System;
using 面向对象初级;

namespace 命名空间
{
    class Program
    {

        /*
         * 命名空间
         * 1.可以认为类是属于命名空间的
         * 
         * 
         * 在一个项目中引用另一个项目的类
         * 1.添加引用
         * 2.引用命名空间
         * 
         */

        static void Main(string[] args)
        {
            Pet p = new Pet();
            p.SayHello();
            Console.WriteLine("Hello World!");
        }
    }
}
