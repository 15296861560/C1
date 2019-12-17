using System;

namespace 部分类
{
    //部分类：用于表示一个类中的一部分
    //部分类主要用于当一个类中的内容较多时将相似类中的内容拆分到不同的类中，并且部分类的名称必须相同
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public partial class P
    {
        private string _name;

    }

    public partial class P
    {
        private void Test()
        {

        }
    }

}
