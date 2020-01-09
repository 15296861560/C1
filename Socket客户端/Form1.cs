using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket客户端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //创建负责通信的Socket
        Socket socketSend = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            IPAddress ip = IPAddress.Parse(txtServer.Text);
            IPEndPoint endPoint = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //获得要连接的远程服务器应用程序的IP地址和端口号
            socketSend.Connect(endPoint);
            ShowMsg("连接成功");


        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="v"></param>
        void ShowMsg(string v)
        {
            txtLog.AppendText(v + "\r\n");
        }
        /// <summary>
        /// 客户端给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text.Trim();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socketSend.Send(buffer);
        }
    }
}
