using System;

namespace Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果类型相兼容，比如int和double
            //显示类型转换、自动类型转换
            //double-->int大转小（丢失精度）、int-->double小转大

            //如果类型不兼容
            //使用convert转换工厂
            string s = "123";
            int si = Convert.ToInt32(s);
            double sd = Convert.ToDouble(s);
            string ss = Convert.ToString(si);
            string sss = si.ToString();

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
