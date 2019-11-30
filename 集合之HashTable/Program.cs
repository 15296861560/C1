using System;
using System.Collections;

namespace 集合之HashTable
{
    class Program
    {
        /*
         * HashTable:键值对集合
         * 键值对集合中值可以重复但是键必须是唯一的
         * 
         */
        static void Main(string[] args)
        {
            //创建一个键值对集合
            Hashtable ht = new Hashtable();


            ht.Add(1,1);
            ht.Add(2,true);
            ht.Add(3,"33333");
            ht.Add(true,"真的");
            ht.Add("假",false);
            //在键值对集合中，根据建去找值的
            Console.WriteLine(ht[3]);

            //foreach循环遍历Hashtable的值
            foreach (var item in ht.Values)//var:根据值推断出类型
            {
                Console.WriteLine(item);
            }
            //foreach循环遍历Hashtable的键
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(item);
            }
            ht.Contains(2);//判断是否包含某个指定的键
            ht.ContainsValue(2);//判断是否包含某个指定元素
            ht.ContainsKey(2);//判断是否包含某个指定的键

            Console.WriteLine("Hello World!");
        }
    }
}
