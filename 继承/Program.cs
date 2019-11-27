using System;

namespace 继承
{
    /*
     * 继承的特性
     * 1.继承的单根性：一个子类只能有一个父类
     * 2.继承的传递性：
     * 
     * 
     * 
     * 1.子类继承了父类的属性和方法，但是子类并没有继承父类的私有字段
     * 2.子类并没有继承父类的构造函数,但是子类会默认调用父类无参的构造函数创建父类对象，让子类可以使用父类中的成员
     * 
     * 
     * 
     * 在c#中，所有的类都直接或间接继承自object类
     * 如果一个类没有继承哪一个类那么这个类继承了object类
     * 
     * new
     * 1.创建对象
     * 2.隐藏从父类那里继承过来的同名成员
     */


    public class Pet 
    {
        private string _name;
        private int _age;

        public Pet()
        {

            Name = "pet";
            Age = 0;
        }

        public Pet(string name,int age)
        {

            Name = name;
            Age = age;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }



        public void Yell()
        {
            Console.WriteLine("呃呃呃");
        }
    }


    public class Cat:Pet
    {

        public Cat(string name,int age) : base(name, age) { }//显示调用父类有参的构造函数

        public new void Yell()//new隐藏从父类那里继承过来的同名成员
        {
            Console.WriteLine("喵喵喵");
        }
         
    }

    public class Dog : Pet
    {
        public new void Yell()
        {
            Console.WriteLine("汪汪汪");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Pet p = new Pet();
            Cat c = new Cat("MiKi",1);
            c.Age = 10;
            c.Yell();
            Console.WriteLine(c.Age);
            Console.WriteLine(c.Name);
        }
    }
}
