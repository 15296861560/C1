using System;

namespace params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //params称之为可变参数
            //它将实参列表中跟可变参数数组类型一致的元素都当作数组的元素去处理
            //可变参数数组必须是形参列表中的最后一个参数


            SumPrice("小明", 44, 55.6, 44.1);
            Console.WriteLine("Hello World!");
        }

        public static void SumPrice(string pname,params double[] price)
        {
            double sum = 0;
            for(int i = 0; i < price.Length; i++)
            {
                sum += price[i];
            }
            Console.WriteLine("{0}总共需要{1}元", pname, sum);
        }
    }
}
