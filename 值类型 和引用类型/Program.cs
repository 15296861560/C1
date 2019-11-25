using System;

namespace 值类型_和引用类型
{
    class Program
    {

        /*
         * 值类型和引用类型
         * 1.值类型和引用类型在内存上存储的地方不一样
         * 2.在传递值类型和传递引用类型的时候，传递的方式不一样，值类型我们称之为值传递，引用类型我们称之为引用传递
         * 
         * 我们学的值类型和引用类型
         * 值类型：int、double、bool、char、decimal、struct、enum
         * 引用类型：string、自定义类、数组
         * 存储
         * 值类型的值是存储在内存的栈中，而引用类型的值是存储在内存的堆中
         * 
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
