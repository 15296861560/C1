using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 播放音乐下一曲
{
    public partial class Form1 : Form
    {
        //用来存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        //创建一个用来播放音乐的类
        SoundPlayer sp = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"D:\Test\c#\music";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            //获取选中文件的全路径
            string[] path= ofd.FileNames;
            for(int i = 0; i < path.Length; i++)
            {
                //将音乐文件的文件名加载到listBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //将音乐文件的全路径存储到泛型集合中
                listSongs.Add(path[i]);
            }
        }


        /// <summary>
        /// 实现双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            //获取下一曲索引
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //改变选中项
            listBox1.SelectedIndex = index;
            //播放下一曲
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            //获取上一曲索引
            index++;
            if (index <0)
            {
                index = listBox1.Items.Count;
            }
            //改变选中项
            listBox1.SelectedIndex = index;
            //播放上一曲
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
    }
}
