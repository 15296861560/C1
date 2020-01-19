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
    public partial class Form2 : Form
    {
        //全局唯一的单例
        public static Form2 formSingle=null;

        private Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public static Form2 GetSingle()
        {
            if (formSingle == null)
            {
                formSingle = new Form2();
            }
            return formSingle;
        }
    }
}
