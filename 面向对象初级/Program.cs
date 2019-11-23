using System;

namespace 面向对象初级
{
    /*
     * 静态和非静态的区别
     * 1.静态类只能有静态成员，而非静态类中既可以有实例成员也可以有静态成员
     * 2.非静态类在调用实例成员的时候，需要使用对象名.实例成员名；在调用静态成员的时候需要使用类名.静态成员名
     * 3.静态类不能被实例化
     * 
     * 静态类的使用
     * 1.如果你想让你的类当作一个“工具类”去使用，这个时候可以考虑将类写成静态的
     * 2.静态类在整个项目中资源共享
     * 3.程序结束后，静态类才会释放资源
     * 
     * 
     *构造函数的作用：帮助类初始化对象
     * 1.构造函数没有返回值，连void也不能写
     * 2.构造函数的名称必须跟类名一样
     * 3.构造函数修饰符必须是public
     * 4.创建对象的时候调用构造函数
     * 5.构造函数可以重载
     * 6.类当中会有一个默认的无参构造函数，但是当你写了一个了一个新的构造函数之后，原来的默认无参的构造函数就被干掉了
     * 
     * this关键字
     * 1.代表当前类的对象
     * 2.在类当中显示的调用本类的构造函数
     * 
     */


    public class Pet
    {
        private string _kind;
        private string _name;
        private int _age;
        private string _movement;

        public Pet()//无参构造函数
        {
            Kind = "宠物";
            Name = "宠物名";
            Age = 0;
            Movement = "宠物行为";
        }

        public Pet(string kind,string name,int age):this(kind,name,age,"爬")//有参构造函数
        {
        }

        public Pet(string kind, string name, int age,string movement)//(最全的)有参构造函数
        {
            Kind = kind;
            Name = name;
            Age = age;
            Movement = movement;
        }

        public string Kind { get => _kind; set => _kind = value; }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Movement { get => _movement; set => _movement = value; }
        

        public void SayHello()
        {
            Console.WriteLine("这是一只是一只{0}，它叫{1}，它今年{2}岁了，它会{3}",Kind,Name,Age,Movement);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            pet.SayHello();
            Pet cat= new Pet("cat","MiKi",2);
            cat.SayHello();
            Console.WriteLine("Hello World!");
        }
    }
}
