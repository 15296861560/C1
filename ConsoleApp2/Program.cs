using System;

namespace 占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入性别");
            string sex = Console.ReadLine();
            Console.WriteLine("{0}性",sex);
            Console.ReadKey();
        }
    }
}
