using System;

namespace 简单工厂设计模式
{
    /*
     * 
     * 
     */


    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("请输入您想要的衣服颜色");
            string input = Console.ReadLine();
            Clothes clothes = GetClothes(input);
            clothes.display();
        }

        private static Clothes GetClothes(string input)
        {
            switch (input)
            {
                case "red":return new RedClothes();
                case "blue":return new BlueClothes();
            }
            return null;
        }
    }

    public abstract class Clothes
    {


        public abstract void display();
    }

    public class RedClothes : Clothes
    {
        public override void display()
        {
            Console.WriteLine("这是红衣服");
        }
    }

    public class BlueClothes : Clothes
    {
        public override void display()
        {
            Console.WriteLine("这是蓝衣服");
        }
    }


}
