using System;

namespace 显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示实现接口是为了解决方法重名问题
            IFlyable flyable = new Bird();
            flyable.Fly();
            Bird bird = new Bird();
            bird.Fly();
            Console.WriteLine("Hello World!");
        }
        public interface IFlyable
        {
            void Fly();
        }
        public class Bird : IFlyable
        {
            public void Fly()
            {
                Console.WriteLine("鸟会飞");
            }
            /// <summary>
            /// 显示实现接口
            /// </summary>
            void IFlyable.Fly()
            {
                Console.WriteLine("接口的飞");
            }
        }
    }
}
