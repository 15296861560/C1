using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PictureBox控件
{
    public partial class Form1 : Form
    {
        //获得指定文件夹的所有文件的全部路径
        string[] path = Directory.GetFiles(@"D:\Test\c#\picture");
        //设置初始位置
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(path[0]);
           
        }
        /// <summary>
        /// 点击更换上一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i <0)
            {
                i = path.Length-1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
        /// <summary>
        ///  点击更换下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
