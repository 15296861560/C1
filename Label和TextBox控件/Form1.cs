using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label和TextBox控件
{
    /*
     * TextBox控件
     * WordWrap:指示文本框是否换行
     * PasswordChar：让文本框显示一个单一的字符
     * ScollBars：是否显示滚动条
     * 事件：TextChanged当文本框中的内容发生改变的时候触发这个事件
     * 
     */

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 当文本框中的内容发生改变的时候将值赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
