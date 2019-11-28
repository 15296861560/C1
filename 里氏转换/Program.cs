using System;

namespace 里氏转换
{

    /*
     * 
     * 里氏转换
     * 1.子类可以被赋值给父类：如果有一个地方需要一个父类作为参数，我们可以给一个子类代替父类
     * 2.如果父类中装的是子类对象，那么可以讲这个父类强转为子类对象
     * 
     * 
     * 子类对象可以调用父类中的成员，但是父类对象永远只能调用自己的成员
     * 
     * is:表示类型转换，如果能够转换成功返回一个ture否则返回一个false
     * as:表示类型转换，如果能够转换则返回对应的对象，否则返回一个null
     * 
     */

    public class Father
    {
        public void Say()
        {
            Console.WriteLine("我是爸爸");
        }
    }

    public  class Son:Father
    {
        public void Say()
        {
            Console.WriteLine("我是儿子");
        }
    }         

    public class GrandSon : Son
    {
        public void Say()
        {
            Console.WriteLine("我是孙子");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son();
            son.Say();
            Father father = son;//子类可以赋值给父类（此时父类对象中装着子类对象）
            father.Say();
            Son s=(Son)father;
            s.Say();
            Console.WriteLine(son is Father);
            Console.WriteLine(s is Father);
            Console.WriteLine(father is Son);
            father.Say();
            Console.WriteLine(father);
            Console.ReadKey();
        }
    }
}
