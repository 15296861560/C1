using System;

namespace 类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "123";
            string ss = "123abc";

            //使用Convert进行转换，成功了就成功了，失败了就抛异常
            int num1 = Convert.ToInt32(s);

            //Convert.ToInt32（）内部调用了int.Parse,int.Parse失败了也抛异常
            int i = int.Parse(s);
            double sd = double.Parse(s);
            decimal sde = decimal.Parse(s);

            //int.TryParse()如果转换成功则返回true，如果失败则返回false，inttry赋值为0
            int inttry = 1;
            bool b=int.TryParse(ss, out inttry);

            Console.WriteLine(b);
            Console.WriteLine(inttry);
            Console.ReadKey();
        }
    }
}
