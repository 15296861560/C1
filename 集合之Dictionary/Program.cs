using System;
using System.Collections.Generic;

namespace 集合之Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "猫");
            dic.Add(2, "狗");
            dic.Add(3, "猪");
            dic.Add(4, "羊");

            foreach (var item in dic.Keys)//遍历键
            {
                Console.WriteLine("键：{0},值：{1}",item,dic[item]);
            }

            foreach (KeyValuePair<int ,string> kv in dic)//键值对遍历
            {
                Console.WriteLine("键：{0},值：{1}", kv.Key, kv.Value);
            }
            
        }
    }
}
