using System;
using System.Collections;

namespace 集合之ArrayList
{
    class Program
    {
        //我们将一个对象输出到控制台，默认情况下，打印的就是这个对象所在类的命名空间

        static void Main(string[] args)
        {
            //创建了一个集合对象
            ArrayList list = new ArrayList();
            //集合：很多数据的一个集合
            //数组：长度不可变，类型单一
            //集合的好处：长度可以任意改变，类型随便

            list.Add(1);//添加单个元素
            list.Add(true);
            int[] vs = new int[] { 1, 2, 3 };
            list.AddRange(vs);//把集合的每个元素单独添加进去
            list.RemoveAt(0);//根据下标去删除元素
            list.Remove(true);//根据元素内容删除元素
            list.RemoveRange(0,3);//根据下标移除一定范围内的元素
            list.Sort();//升序排列（该集合内的类型要差不多）
            list.Reverse();//将集合内的元素反转
            list.Insert(0, "插入的");//在指定位置插入元素
            list.InsertRange(0, vs);//在指定位置插入一个集合
            list.Contains(0);//判断是否包含某个指定元素

            //count表示这个元素中实际包含的元素的个数
            //capcity表示这个集合中可以包含的元素的个数
            //每次集合中实际包含的元素个数count超过了可以包含元素的个数capcity的时候集合就会向内存申请多开辟一倍的空间，来保证集合的长度一直够用


            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();
        }
    }
}
