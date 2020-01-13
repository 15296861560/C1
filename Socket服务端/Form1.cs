using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket服务端
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;//IPAddress ip=IPAddress.Parse(txtServer.Text);
            //创建端口号对象
            IPEndPoint endPoint = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //监听
            socket.Bind(endPoint);
            ShowMsg("监听成功");
            //设置挂起的连接队列最大长度
            socket.Listen(10);
            //开启一个新线程去等待客户端的连接
            Thread th = new Thread(Listen);
            th.Start(socket);

        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="v"></param>
        void ShowMsg(string v)
        {
            txtLog.AppendText(v + "\r\n");
        }




        Socket socketSend;
        /// <summary>
        /// 等待客户端的连接，并且与之通信用的Socket
        /// </summary>
        void Listen(object o)
        {
            //将对象转为Socket
            Socket socket = o as Socket;
            //等待客户端的连接，并且创建一个负责通信的Socket
            while (true)
            {
                socketSend = socket.Accept();
                //将远程连接的客户端IP地址和Socket存入集合中
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                //将远程连接的客户端的IP地址和端口号存入下拉框中
                cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                //显示客户端ip地址并提示连接成功
                ShowMsg(socketSend.RemoteEndPoint.ToString() + ":连接成功");
                //开启一个不停接收客户端发送过来消息的一个新线程
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start(socketSend);

            }

        }

        //将远程连接的客户端IP地址和Socket存入集合中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 服务器不停地接收客户端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {

                    //客户端连接成功后，服务器接受来自客户端的消息并将其存入一个字节数组里
                    byte[] buffer = new byte[1024 * 1024];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    //对字节数组进行解码
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    //显示客户端的端口号和他发送过来的消息
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                {

                }
            }
        }/// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[1];
                buffer[0] = 2;
                dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
            }
            catch
            {

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载的时候取消多线程的检查
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 服务端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string str = txtMsg.Text;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
                //创建一个泛型集合存储协议和想发送过去的数据
                List<byte> list = new List<byte>();
                list.Add(0);
                list.AddRange(buffer);
                //将泛型集合转换为数组
                byte[] newBuffer = list.ToArray();
                //获得用户在下拉框中选中的IP地址
                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer);
                //socketSend.Send(buffer);
            }
            catch
            {

            }


        }
        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //设置初始目录
            ofd.InitialDirectory = @"D:\Test\c#\file";
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            //将选中文件的全路径赋值给文本框
            filePath.Text = ofd.FileName;
        }

        private void sendFile_Click(object sender, EventArgs e)
        {
            //获取要发送文件的路径
            string path = filePath.Text;
            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024*5];
                int r = fileStream.Read(buffer, 0, buffer.Length);
                //创建一个泛型集合存储协议和想发送过去的数据
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                //将泛型集合转换为数组
                byte[] newBuffer = list.ToArray();           
                dicSocket[cboUsers.SelectedItem.ToString()].Send(newBuffer,0,r+1,SocketFlags.None);
            }
        
        }
    }
}
