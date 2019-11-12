using System;

namespace 函数
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * 函数就是将一堆代码进行重用的一种机制
             * 方法名：Pascal每个单词首字母都大写，其余小写
             * 
             * 语法
             * 
             * [访问权限] （static） 返回类型 函数名（参数类型 形参名1，参数类型 形参名2）
             * {
             * 方法体；
             * 
             * （return）符合返回类型的参数；//void无返回值
             * }
             * 
             * 
             * return的作用：
             * 1.立即结束当前函数
             * 2.返回要返回的值
             * */

            int a = 0, b = 3;
            int c=GetSum(a, b);//如果该方法和Main（）函数同在一个类中，这个时候类名可以省略
            c = Program.GetSum(a,b);
            Console.WriteLine(c);
        }

        /// <summary>
        /// 计算两个整数的和
        /// </summary>
        /// <param name="a">第一个整数</param>
        /// <param name="b">第二个整数</param>
        /// <returns>返回这两个数的和</returns>
        public static int GetSum(int a,int b)//求和函数
        {
            return a + b;
        }
    }
}
