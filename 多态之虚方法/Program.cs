using System;

namespace 多态之虚方法
{
    /*
     * 多态概念：让一个对象能够表现出多种状态（类型）
     * 实现多态的三种手段：1虚方法，2抽象类，3接口
     * 
     * 1.虚方法
     * 步骤
     * 1.）将父类的方法标记为虚方法，使用关键字virtual(这个方法可以被子类重写）
     * 2.）当父类的方法不知道如何去实现的时候，可以考虑将父类写成抽象类将方法写成抽象方法
     */

    class Program
    {
        public class Pet
        {
            private string _name;
            private int _age;

            public Pet()
            {
                Name = "pet";
                Age = 0;
            }

            public Pet(string name, int age)
            {

                Name = name;
                Age = age;
            }

            public string Name { get => _name; set => _name = value; }
            public int Age { get => _age; set => _age = value; }



            public virtual void Yell()
            {
                Console.WriteLine("呃呃呃");
            }
        }


        public class Cat : Pet
        {

            public Cat(string name, int age) : base(name, age) { }//显示调用父类有参的构造函数

            public override void Yell()//override重写从父类那里继承过来的同名方法
            {
                Console.WriteLine("它是一只叫{0}的猫，平常喵喵喵的叫",Name);
            }

        }

        public class Dog : Pet
        {

            public Dog(string name, int age) : base(name, age) { }//显示调用父类有参的构造函数

            public override void Yell()
            {
                Console.WriteLine("它是一只叫{0}的狗，平常汪汪汪的叫", Name);
            }

        }


        static void Main(string[] args)
        {
            Pet[] pet = new Pet[3];
            Cat cat1 = new Cat("小白",1);
            Cat cat2 = new Cat("小黑",2);
            Dog dog1 = new Dog("小黄", 1);
            pet[0]=cat1;
            pet[1]=cat2;
            pet[2]=dog1;

            foreach (var item in pet)
            {
               item.Yell();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
