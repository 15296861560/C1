using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单例模式
{
    /*
     * 单例模式
     * 1.将构造函数私有化
     * 2.提供一个静态方法返回一个对象
     * 3.创建一个单例
     */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 =Form2.GetSingle();
            form2.Show();
        }
    }
}
