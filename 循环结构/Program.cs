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


            //for循环语法：for（表达式1；表达式2；表达式3）{循环体；}
            //表达式1：一般为声明循环变量，记录循环的次数
            //表达式2：一般为循环条件
            //表达式3：一般为改变循环条件的代码
            //执行顺序：表达式1-》表达式2成立-》循环体-》表达式3-》表达式2成立-》循环体-》表达式3-》表达式2不成立-》跳出循环
            for (i = n; i > 0; i--)
            {
                Console.WriteLine("I'm for " + "i=" + i);
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
