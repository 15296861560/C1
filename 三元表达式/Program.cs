using System;

namespace 三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            /**语法：表达式1？表达式2：表达式3；
             * 表达式1一般为一个关系表达式
             * 如果表达式1的值为true，那么表达式2的值就是整个三元表达式的值
             * 如果表达式1的值为false，那么表达式3的值就是整个三元表达式的值
             * 表达式2的结果类型必须跟表达式3的结果类型一致，并且也要跟整个三元表达式的结果类型一致
             * */

            int a = 1 > 2 ? 111 : 222;
            bool b=1>2?true:false;
            string s = 1 < 2 ? "2" : "1";

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(s);
        }
    }
}
