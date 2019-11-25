using System;
using System.Text;

namespace 字符串
{

    /*
     * 字符串：
     * 1.字符串的不可变性
     * 当你给一个字符串重新赋值的时候，老值不会销毁，而是指向一个新值
     * 2.我们可以将字符串看成一个char类型的一个只读数组 
     * 
     * 
     * 
     * 当程序结束后，gc扫描整个内存如果有没有被引用的值将会将其回收
     * 
     * 字符串的常用方法
     * 1.Length：获取当前字符串的字符数
     * 2.ToUpper（）：将字符串转化为大写
     * 3.ToLower（）：将字符串转化为小写写
     * 4.Equals(s2,StringComparison.OrdinalIgnoreCase)：比较两个字符串，忽略大小写
     * 5.Split（）:分割字符串，返回一个字符串类型的数组
     * 6.Contains(s)：判断字符串是否有子字符串s
     * 7.Replace(old value,new value):将字符串中的old value字符替换成new value
     * 8.Substring(starPlace,endPlace)：截取索引从starPlace到endPlace的字符串
     * 9.StartsWith(start):是否以strat字符串开头
     * 10./EndsWith(end)是否以end字符串结尾
     * 11.IndexOf(s)：字符串s在字符串中第一次出现的位置
     * 12.LastIndexOf(s)：字符串s在字符串中最后一次出现的位置
     * 13.Trim()：移除字符串前后的空格
     * 14.TrimEnd()：移除字符串后面的空格
     * 15.TrimStrat()：移除字符串前面的空格
     * 16.IsNormalized()：判断字符串是否为空
     * 17.string.Join(a,b)：将指定分隔符a加入 字符串数组b中除最后一个元素外的每一个元素后面
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            //s1与s2共同指向堆中的同一个空间
            string s1 = "123";
            string s2 = "123";
            Console.WriteLine(s1.Equals(s2));
            //通过索引访问string
            Console.WriteLine(s1[0]);
            //将string转换为char数组
            char[] sc = s1.ToCharArray();
            //将字符数组转换为string字符串
            s1 = new string(sc);
            Console.WriteLine(s1.Equals(s2));
            


            //Equals(s2,StringComparison.OrdinalIgnoreCase)
            string sa = "aaa";
            string sA = "AAA";
            Console.WriteLine(sa.Equals(sA,StringComparison.OrdinalIgnoreCase));
            //分割字符串Split
            string ss = "a  b   s  +  q  ! f";
            char[] chs = { ' ', '+', '!' };//分割符
            string[] sss= ss.Split(chs,StringSplitOptions.RemoveEmptyEntries);//分割字符串并移除空项
            Console.WriteLine(sss);
            //判断字符串是否有子字符串Contains()
            Console.WriteLine(sa.Contains('a'));
            //字符串替换Replace(old value,new value)
            Console.WriteLine(sa.Replace('a','b'));
            //截取字符串Substring(starPlace,endPlace)
            string str = "abcdefg";
            Console.WriteLine(str.Substring(1,3));
            //StartsWith(start)是否以strat字符串开头
            Console.WriteLine(str.StartsWith('a'));
            //EndsWith(end)是否以end字符串结尾
            Console.WriteLine(str.EndsWith("fg"));
            //IndexOf(s)字符串s在字符串中第一次出现的位置
            Console.WriteLine(str.IndexOf('b'));
            //LastIndexOf(s)字符串s在字符串中最后一次出现的位置
            Console.WriteLine(str.EndsWith('g'));
            //Trim()移除字符串前后的空格
            string str2 = "   abc   ";
            Console.WriteLine(str2.Trim());
            //Trim()移除字符串后面的空格
            Console.WriteLine(str2.TrimEnd());
            //Trim()移除字符串前面的空格
            Console.WriteLine(str2.TrimStart());
            //IsNormalized()判断字符串是否为空
            Console.WriteLine(str2.IsNormalized());
            //string.Join(a,b)将指定分隔符a加入 字符串数组b中除最后一个元素外的每一个元素后面
            string[] str3 = { "a", "b", "c" };
            Console.WriteLine(string.Join("|",str3));


        }
    }
}
