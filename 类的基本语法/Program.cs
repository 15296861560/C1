using System;

namespace 类的基本语法
{
    public class Person
    {
        public string _name;//字段

        public string Name//属性
        {
            get { return _name; }//当你输出属性的值的时候会执行get方法
            set { _name = value; }//当你给属性赋值的时候首先会执行set方法
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value; 
            }
        }


        public void incAge()//方法
        {
            _age ++;
        }
    }

    class Program
    {

        /**
         * 语法：
         * 访问权限 [] class 类名{
         * 
         *  访问权限 数据类型 字段名；
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
         * Field字段，Method方法，Property属性
         * 
         * 
         * 属性的本质就是get和set方法，属性不存值，只是起到一个过渡作用
         * 既有get又有set称之为可读可写属性
         * 只有get没有set称之为只读属性
         * 没有get只有set称之为只写属性
         * 
         * 
         * */

        

        static void Main(string[] args)
        {
            Person p ;//自定义类
            p = new Person();//创建Person类的对象
            p._name = "小p";
            p.Age = 16;
            p.incAge();

            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
        }
    }
}
