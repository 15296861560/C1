using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace 装箱和拆箱
{
    /*
     * 装箱：将值类型转换为引用类型
     * 拆箱：将引用类型转换为值类型
     * 
     * 条件：看两种类型是否发生了装箱或者拆箱要看这两种类型是否存在继承关系
     */

    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            object o = n;//装箱
            int nn = (int)o;//拆箱
            Stopwatch sw = new Stopwatch();
            ArrayList arrayList = new ArrayList();
            sw.Start();
            for(int i = 0; i <100000; i ++)
            {
                arrayList.Add(i);//装箱操作，将int类型转换为object类型
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            List<int> list = new List<int>();
            Stopwatch s = new Stopwatch();
            s.Start();
            for (int i = 0; i < 100000; i++)
            {
                list.Add(i);
            }
            s.Stop();
            Console.WriteLine(s.Elapsed);


            //这个地方  没有发生任意类型的装箱或者拆箱
            //string str = "111";
            //int ntr=Convert.ToInt32(str);



        }
    }
}
