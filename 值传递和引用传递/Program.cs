using System;

namespace 值传递和引用传递
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
         * 
         * 值传递和引用传递
         * 1.值类型在复制的时候，传递的是这个值本身
         * 2.引用类型在复制的时候，传递的是对这个对象的引用
         * 
         * 
         */


        public class Pet
    {
        public int age;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = n1;
            n2 = 2;
            Console.WriteLine("n1={0},n2={1}",n1,n2);

            Pet pet1 = new Pet();
            pet1.age = 1;
            Pet pet2 = pet1;
            pet2.age = 2;
            Console.WriteLine("pet1的age={0},pet2的age={1}", pet1.age, pet2.age);

            //字符串类型虽然是引用类型，但是因为它的不可变性，所以它每次赋值的时候都会新开辟一个空间
            string s1 = "111";
            string s2 = s1;
            s2 = "222";
            Console.WriteLine("s1={0},s2={1}", s1,s2);

        }
    }
}
