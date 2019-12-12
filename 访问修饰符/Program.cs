using System;

namespace 访问修饰符
{
    /*
     * 访问修饰符：
     * public:公开的公共的
     * private:私有的，只能在当前类的内部访问
     * protected:受保护的，只能在当前类的内部以及该类的子类中访问
     * internal:只能在当前（程序集）项目中访问,在同一个项目中internal和public的权限是一样的
     * protected internal:protected+internal
     * 
     * 1.能够修饰类的访问修饰访问符只有public和internal
     * 2.可访问性不一致：
     *  子类的访问权限不能高于父类的访问权限，否则会暴露父类不想暴露的成员
     * 
     */


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
