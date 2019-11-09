using System;

namespace 生成随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生随机数
            //1.创建能够产生随机数的对象
            Random r = new Random();
            //2.让产生随机数的对象调用方法来产生随机数
            int rN = r.Next(1, 10);//取值范围是左闭右开区间【1，10），而且是int类型
            double rD = r.NextDouble();//生成0.0到1.0之间的double类型随机数
            for(int i = 0; i < 10; i++)
            {
                rN = r.Next(1, 10);
                Console.WriteLine(rN);
                rD = r.NextDouble();
                Console.WriteLine(rD);
            }
           
        }
    }
}
