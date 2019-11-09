using System;

namespace 断点调试
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 调试：
             * 设置断点（在行号前点击空白处）
             * 单步运行（F11逐语句调试）
             * 观察变量（鼠标放在变量名上观察）
             * F10逐过程调试
             * F11进入调试则是从main函数开始，F5进入调试则是从第一个断点开始
             * 值为红色表示刚刚进行转变
             * */


            string s = "123";
            string ss = "123abc";
            int inttry = 1;
            bool b = int.TryParse(ss, out inttry);
            bool b2 = int.TryParse(s, out inttry);


            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
