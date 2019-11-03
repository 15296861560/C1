using System;

namespace switch和case
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            string s = "ss";
            /**
             switch-case:程序执行到switch处，根据括号中的值或者表达式与case后面的值进行匹配，一旦匹配成功，
            则执行case后面的代码，遇到break则跳出switch-case结构，如果跟每个case后面所带的值都不匹配，
            就看当前这个switch-case结构中是否存在default，如果有default则执行default中的语句，否则 就什么都不做。
             **/
            switch (a)
            {
                default:
                    Console.WriteLine(a);
                    break;
                case 1: Console.WriteLine(a);
                    break;
                case 2:
                    Console.WriteLine(a);
                    break;
                
            }
            switch (s)
            {
                default:
                    Console.WriteLine(s);
                    break;
                case "a":
                    Console.WriteLine(a);
                    break;
                case "s":
                    Console.WriteLine("?");
                    break;
                case "ss":
                    Console.WriteLine(s);
                    break;

            }
            Console.WriteLine("over");
        }
    }
}
