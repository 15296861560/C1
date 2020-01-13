namespace Socket服务端
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.txtMsg = new System.Windows.Forms.RichTextBox();
            this.filePath = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sendFile = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(53, 48);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(156, 25);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "192.168.137.1";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(234, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(91, 25);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "50000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始监听";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(53, 90);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(645, 109);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(53, 217);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(645, 116);
            this.txtMsg.TabIndex = 4;
            this.txtMsg.Text = "";
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(53, 373);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(423, 25);
            this.filePath.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sendFile
            // 
            this.sendFile.Location = new System.Drawing.Point(606, 375);
            this.sendFile.Name = "sendFile";
            this.sendFile.Size = new System.Drawing.Size(92, 23);
            this.sendFile.TabIndex = 7;
            this.sendFile.Text = "发送文件";
            this.sendFile.UseVisualStyleBackColor = true;
            this.sendFile.Click += new System.EventHandler(this.sendFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(497, 415);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(98, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "发送信息";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(623, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "震动";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.BackColor = System.Drawing.SystemColors.Window;
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(534, 49);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(164, 23);
            this.cboUsers.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboUsers);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.sendFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.RichTextBox txtMsg;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button sendFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboUsers;
    }
}

