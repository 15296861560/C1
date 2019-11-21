using System;

namespace 类的基本语法
{
    public class Person
    {
        public string _name;
        int _age;


        public void setAge(int newAge)
        {
            _age = newAge;
        }
    }

    class Program
    {

        /**
         * 语法：
         * 访问权限 [] class 类名{
         * 
         *  访问权限 数据类型 属性名；
         *  
         *  
         *  访问权限 [static] 返回类型 方法名（参数列表）
         *  {
         *  } 
         * 
         * }
         * 
         * 
         * 
         * 
         * 类是不占内存的，而对象是占用内存的
         * 
         * */

        

        static void Main(string[] args)
        {
            Person p ;//自定义类
            p = new Person();//创建Person类的对象
            p._name = "小p";
            p.setAge(18);

            Console.WriteLine(p._name);
        }
    }
}
