using System;

namespace break的用法
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //break作用：1.跳出switch-case结构
            //2.跳出当前循环体
            while (i<10)
            {
                i++;
                if (i == 5) break;
            }
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
