using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI窗口设计
{
    /*
     * MDI窗口设计
     * 1.首先确定一个父窗体，将IsMdiContainer设置为true
     * 2.创建子窗口并设置父窗口
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

        private void 显示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Form();
            form2.Show();
            form2.MdiParent = this;
            Form form3 = new Form();
            form3.Show();
            form3.MdiParent = this;
            Form form4 = new Form();
            form4.Show();
            form4.MdiParent = this;
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
