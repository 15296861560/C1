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
             * 枚举类型默认可以与int类型转换,默认按枚举顺序从0开始计数
             * int类型也可以转换为枚举类型
             * 所有类型都能转换为string类型
             * */

            Gender gender = Gender.女;
            Console.WriteLine(gender);
            #region 枚举类型转换为int类型
            int n = (int)gender;
            Console.WriteLine(n);
            #endregion
            #region int类型转换为枚举类型
            Gender man = (Gender)0;
            Console.WriteLine(man);
            #endregion
            #region 字符串类型与枚举类型
            string sn = "0", sex = "女";
            Gender g1= (Gender)Enum.Parse(typeof(Gender),sn);//把字符串转换为枚举类型,如果字符串是数字，枚举中没有也不会抛异常
            Gender g2= (Gender)Enum.Parse(typeof(Gender),sex);//把字符串转换为枚举类型，如果字符串是文本，枚举中没有就会抛出异常            
            Console.WriteLine(g1);
            Console.WriteLine(g2);
            #endregion
        }
    }
}
