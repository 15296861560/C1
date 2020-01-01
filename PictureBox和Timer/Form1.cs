using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox和Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            //窗体加载的时候给 每个PictureBox都赋值一张图片的路径
            pictureBox1.Image = Image.FromFile(@"D:\Test\c#\picture\1.jpg");
            pictureBox2.Image = Image.FromFile(@"D:\Test\c#\picture\1.jpg");
            pictureBox3.Image = Image.FromFile(@"D:\Test\c#\picture\1.jpg");
        }
        string[] path = System.IO.Directory.GetFiles(@"D:\Test\c#\picture");
        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //每隔一秒钟换一张图片
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox3.Image = pictureBox2.Image;
            pictureBox2.Image = pictureBox1.Image;
            pictureBox1.Image=Image.FromFile(path[i]);
            
        }
    }
}
