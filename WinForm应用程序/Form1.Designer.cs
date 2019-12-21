namespace WinForm应用程序
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(345, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "文本内容";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制1ToolStripMenuItem,
            this.复制2ToolStripMenuItem});
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.复制ToolStripMenuItem.Text = "复制";
            // 
            // 复制1ToolStripMenuItem
            // 
            this.复制1ToolStripMenuItem.Name = "复制1ToolStripMenuItem";
            this.复制1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.复制1ToolStripMenuItem.Text = "复制1";
            // 
            // 复制2ToolStripMenuItem
            // 
            this.复制2ToolStripMenuItem.Name = "复制2ToolStripMenuItem";
            this.复制2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.复制2ToolStripMenuItem.Text = "复制2";
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粘贴1ToolStripMenuItem});
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            // 
            // 粘贴1ToolStripMenuItem
            // 
            this.粘贴1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.粘贴11ToolStripMenuItem});
            this.粘贴1ToolStripMenuItem.Name = "粘贴1ToolStripMenuItem";
            this.粘贴1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.粘贴1ToolStripMenuItem.Text = "粘贴1";
            // 
            // 粘贴11ToolStripMenuItem
            // 
            this.粘贴11ToolStripMenuItem.Name = "粘贴11ToolStripMenuItem";
            this.粘贴11ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.粘贴11ToolStripMenuItem.Text = "粘贴11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 414);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴11ToolStripMenuItem;
    }
}

