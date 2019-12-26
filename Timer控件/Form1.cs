using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer控件
{
    //Timer：在指定的时间间隔内做一件事情
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 滚动label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text[0];
        }

        /// <summary>
        /// 每隔一秒钟把当前时间赋值给label2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            //指定时间播放音乐
            if(DateTime.Now.Hour==11&& DateTime.Now.Minute==44&& DateTime.Now.Second == 33)
            {
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"D:\Test\c#\REMINDER.WAV";
                sp.Play();
            }
        }
        /// <summary>
        /// 窗体加载的时候将当前系统的时间赋值给label2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
