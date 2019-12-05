using System;
using System.Collections.Generic;
using System.Linq;

namespace 泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {

            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);//集合类型确定添加的元素类型也确定了
            int[] l = list.ToArray();//List泛型集合可以转化为数组
            List<int> list2=l.ToList();//数组转化为泛型集合
            Console.WriteLine("Hello World!");
        }
    }
}
