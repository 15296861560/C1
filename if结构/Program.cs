using System;

namespace if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            if(判断条件）{
            执行代码；
            }
            判断条件：一般为关系表达式或者bool类型

            else与最近的if配对
             * */

            int a = 0;
            if (a > 100)
            {
                a = 1;
            }
            else if (a == 0)
            {
                a = 2;
            }
            else
            {
                a = 3;
            }
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
