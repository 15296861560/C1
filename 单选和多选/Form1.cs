using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单选和多选
{
    /*
     * checked：指示这个控件是否处于选中状态
     * 默认情况下，在一个窗体中，所有的单选按钮（RadioButton）只允许选中一个，可以使用groupbox
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (color1.Checked )
            {
                MessageBox.Show("您选中了黑");
            }
            else if(color2.Checked )
            {
                MessageBox.Show("您选中了白");
            }
            else 
            {
                MessageBox.Show("您未选择颜色");
            }
            
        }
    }
}
