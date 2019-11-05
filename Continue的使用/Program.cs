using System;

namespace Continue的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            // continue：不执行当前循环体的剩余内容，直接回到循环条件
            int i = 0,j=0;
            while (i<10)
            {
                i++;
                if (i == 5)
                {
                    continue;
                }
                j++;
            }


            Console.WriteLine("i="+i+"j="+j);
        }
    }
}
