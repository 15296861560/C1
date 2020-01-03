using System;
using System.Diagnostics;
using System.Threading;

namespace 线程和进程
{
    //进程和线程的关系：一个进程包含多个进程
    //1.如果线程执行的方法需要参数，那么要求这个参数必须是object类型
    class Program
    {
        static void Main(string[] args)
        {
            //通过进程去打开应用程序
            //Process.GetProcesses();
            //Process.Start("notepad");//打开记事本

            //通过进程打开指定文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"D:\Test\c#\new.txt");
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();

            Thread th =new Thread(Test1);
            th.IsBackground = true;
            th.Start("1");
            Console.WriteLine("Hello World!");

        }

        private static void Test1(object o)
        {
            string s = (string)o;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+s);
            }
        }
    }
}
