using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Can_You_Choose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你终于点到我了哈哈哈");
            this.Close();//关闭主窗口 
        }
        /// <summary>
        /// 当鼠标进入按钮的可见部分的时候给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            int x = this.ClientSize.Width-button2.Width;//窗体宽度减去按钮宽度就是能够活动的最大宽度
            int y = this.ClientSize.Height-button2.Height;//窗体宽度减去按钮宽度就是能够活动的最大宽度

            Random r = new Random();
            button2.Location = new Point(r.Next(0,x+1),r.Next(0,y+1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你只能选是");
            this.Close();//关闭主窗口 
        }
    }
}
