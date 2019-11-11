using System;

namespace 结构
{
    public struct Pet
    {
        public string _name;
        public int _age;
        string _movement;
        char _gender;
    }


    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 结构可以帮助我们一次性声明多个不同类型的变量
             * 
             * 语法：
             * public struct 名字
             * {
             *     字段；
             * }
             * 
             * 规范上要求我们要在字段前面加下划线
             * */

            Pet pet;
            pet._age = 1;
            pet._name = "小白";

            Console.WriteLine("Hello World!");
        }
    }
}
