using System;

namespace 数组的定义
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * 数组作用：一次性存储多个相同类型的变量
             * 
             * 语法：
             * 数组类型[] 数组名字=new 数组类型[数组长度]；
             * 
             * 数组最后一个元素下标为数组长度减一
             * 数组的长度一旦固定了就不能改变
             * 
             *
             * */

            int[] nums = new int[10];


            #region 数组的其它声明方式
            int[] n2 = { 1, 2, 3 };

            int[] n3 = new int[3] { 1, 2, 3 };

            int[] n4 = new int[] { 1, 2, 3 };

            #endregion

            Console.WriteLine("Hello World!");
        }
    }
}
