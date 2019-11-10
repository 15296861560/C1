using System;

namespace 枚举
{
    public enum Gender
    {
        男,
        女
    }

    class Program
    {   

        static void Main(string[] args)
        {

            /**
             * 语法：
             * [public] enum 枚举名
             * {
             * 值1,
             * 值2,
             * 值3,
             * ...
             * }
             * 
             * public:访问修饰符。公开的，哪都可以访问
             * */

            Gender gender = Gender.女;
            Console.WriteLine(gender);
        }
    }
}
