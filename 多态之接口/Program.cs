using System;

namespace 多态之接口
{
    /*
     * 接口就是一个规范、能力。
     * 只要一个类继承了接口就必须实现接口中的所有方法
     * 接口不能实例化
     * 接口不能继承类，接口只能继承接口，而类既能继承接口也能继承类
     * 一个类可以继承一个类和多个接口，语法上必须先继承类
     * 
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            IFlyable flyable = new Bird();
            flyable.Fly();
            Console.WriteLine("Hello World!");
        }
    }

    public interface IFlyable
    {
        //接口中的成员不允许添加访问修饰符，默认就是public
        //接口中不允许写字段但是可以有自动属性
        //接口中不允许写方法体
        void Fly();
    }

    public interface IClimbable
    {
        void Climb();
    }

    public class Pet
    {

    }

    public class Bird:Pet,IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
    }
}
