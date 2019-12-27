namespace 单选和多选
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.boy = new System.Windows.Forms.RadioButton();
            this.girl = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.color1 = new System.Windows.Forms.RadioButton();
            this.color2 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(190, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(190, 124);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(190, 178);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // boy
            // 
            this.boy.AutoSize = true;
            this.boy.Location = new System.Drawing.Point(6, 24);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(43, 19);
            this.boy.TabIndex = 3;
            this.boy.TabStop = true;
            this.boy.Text = "男";
            this.boy.UseVisualStyleBackColor = true;
            // 
            // girl
            // 
            this.girl.AutoSize = true;
            this.girl.Location = new System.Drawing.Point(6, 74);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(43, 19);
            this.girl.TabIndex = 4;
            this.girl.TabStop = true;
            this.girl.Text = "女";
            this.girl.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boy);
            this.groupBox1.Controls.Add(this.girl);
            this.groupBox1.Location = new System.Drawing.Point(387, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性别";
            // 
            // color1
            // 
            this.color1.AutoSize = true;
            this.color1.Location = new System.Drawing.Point(6, 24);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(43, 19);
            this.color1.TabIndex = 6;
            this.color1.TabStop = true;
            this.color1.Text = "黑";
            this.color1.UseVisualStyleBackColor = true;
            // 
            // color2
            // 
            this.color2.AutoSize = true;
            this.color2.Location = new System.Drawing.Point(6, 75);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(43, 19);
            this.color2.TabIndex = 7;
            this.color2.TabStop = true;
            this.color2.Text = "白";
            this.color2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.color1);
            this.groupBox2.Controls.Add(this.color2);
            this.groupBox2.Location = new System.Drawing.Point(387, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "颜色";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "测试";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton boy;
        private System.Windows.Forms.RadioButton girl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton color1;
        private System.Windows.Forms.RadioButton color2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}

