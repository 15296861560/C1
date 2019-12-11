using System;

namespace 多态之抽象类
{

    public abstract  class Pet
    {
       


        public abstract void Yell();//抽象函数没有方法体
        
    }


    public class Cat : Pet
    {

        public override  void Yell()//
        {
            Console.WriteLine("喵喵喵");
        }

    }

    public class Dog : Pet
    {
        public override void Yell()
        {
            Console.WriteLine("汪汪汪");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Cat();
            Pet pet2 = new Dog();
            pet.Yell();
            pet2.Yell();

            Console.WriteLine("Hello World!");
        }
    }
}
