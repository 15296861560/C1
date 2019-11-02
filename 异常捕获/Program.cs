using System;

namespace 异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //异常：语法上没有错误，在程序运行的过程当中，由于某些原因程序出现了错误，不能再正常的运行

            /**
             try{
            可能出现异常的代码；
            }
            catch{
            出现异常后要执行的代码；
            }
             **/


            int a = 1, b = 0;
            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch
            {
                Console.WriteLine("出现异常");
            }
            
            Console.ReadKey();
        }
    }
}
