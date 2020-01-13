using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
            try
            {
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                IPEndPoint endPoint = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
                //获得要连接的远程服务器应用程序的IP地址和端口号
                socketSend.Connect(endPoint);
                ShowMsg("连接成功");
                //开启一个新线程不停的接受服务端发来的消息
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start();

            }
            catch
            {

            }



        }

        /// <summary>
        /// 客户端不停地接收服务端端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive()
        {
            while (true)
            {
                try
                {

                    //客户端连接成功后，客户端接受来自服务端的消息并将其存入一个字节数组里
                    byte[] buffer = new byte[1024 * 1024*3];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    //查看协议
                    int p = buffer[0];
                    //若未接受到数据
                    if (r == 0)
                    {
                        break;
                    }
                        if (p== 0)//发送的是文字消息
                    {
                        
                        //,对字节数组进行解码
                        string str = Encoding.UTF8.GetString(buffer, 1, r-1);
                        //显示服务端端的端口号和他发送过来的消息
                        ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                    }
                    
                }
                catch
                {

                }
            }
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
