 using System;

namespace 关系运算符和逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            //关系运算符：>,<,>=,<=,==,!=
            //由关系运算符连接的表达式称之为关系表达式
            //关系表达式的结果是bool类型
            bool b = 30 > 1;
            //逻辑运算符：&&逻辑与，||逻辑或，！逻辑非
            //由逻辑运算符连接的表达式称之为逻辑表达式
            //逻辑运算符两边放的一般都是关系表达式或者bool类型的值
            //优先级！>&&>||
            b = true && false;
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
