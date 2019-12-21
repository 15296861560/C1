using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm应用程序
{
    static class Program
    {
        /*
         * 1.winform应用程序是一种智能客户端技术，我们可以使用winform应用程序帮助我们获得信息或者传输信息等
         * 
         * 2.属性
         * Name：在后台要获得前台的控件对象，需要使用Name属性
         * vidible：指示一个控件是否可见
         * Enabled：指示一个控件是否可见
         * 。。。
         * 
         * 3.事件：发生一件事情
         * 注册事件：双击控件注册的都是控件默认被选中的那个事件
         * 触发事件：
         * 
         * 4.在Main函数中创建的窗体对象我们称之为这个窗体应用程序的主窗体。当你主窗体关闭后，整个应用程序都关闭了。
         */


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
