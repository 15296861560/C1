using System;

namespace for循环嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            //把for循环整体看成单个语句，{}省略
            for (i= 0;i<2;i++)
            for (j= 0;j<2;j++)
                {
                    Console.WriteLine("i="+i+"j="+j);
                }
            //标准嵌套
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("i=" + i + "j=" + j);
                }
            }
                



        }
    }
}
