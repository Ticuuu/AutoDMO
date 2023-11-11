namespace DMOAuto
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnSearchPro = new System.Windows.Forms.Button();
            this.lblProId = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.pibMonster = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchPro
            // 
            this.btnSearchPro.Location = new System.Drawing.Point(21, 25);
            this.btnSearchPro.Name = "btnSearchPro";
            this.btnSearchPro.Size = new System.Drawing.Size(75, 25);
            this.btnSearchPro.TabIndex = 0;
            this.btnSearchPro.Text = "Link Start";
            this.btnSearchPro.UseVisualStyleBackColor = true;
            this.btnSearchPro.Click += new System.EventHandler(this.ProSearch);
            // 
            // lblProId
            // 
            this.lblProId.AutoSize = true;
            this.lblProId.Location = new System.Drawing.Point(102, 30);
            this.lblProId.Name = "lblProId";
            this.lblProId.Size = new System.Drawing.Size(55, 13);
            this.lblProId.TabIndex = 1;
            this.lblProId.Text = "暂无进程";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 40);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Go";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.AllStart);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "W";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Mody);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 4;
            this.button2.Text = "A";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Mody);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 5;
            this.button3.Text = "D";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Mody);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 6;
            this.button4.Text = "S";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Mody);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(115, 72);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(83, 40);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.AllStop);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(104, 266);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 25);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.Mody);
            // 
            // txtBox
            // 
            this.txtBox.AcceptsReturn = true;
            this.txtBox.Location = new System.Drawing.Point(480, 170);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(312, 233);
            this.txtBox.TabIndex = 9;
            // 
            // pibMonster
            // 
            this.pibMonster.Location = new System.Drawing.Point(278, 25);
            this.pibMonster.Name = "pibMonster";
            this.pibMonster.Size = new System.Drawing.Size(40, 43);
            this.pibMonster.TabIndex = 10;
            this.pibMonster.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 25);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 68);
            this.button5.TabIndex = 11;
            this.button5.Text = "Select Monster";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SelectMonster);
            // 
            // txtCor
            // 
            this.txtCor.Location = new System.Drawing.Point(437, 30);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(100, 20);
            this.txtCor.TabIndex = 12;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(324, 99);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 13;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(324, 125);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(437, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 20);
            this.button6.TabIndex = 15;
            this.button6.Text = "Select with cursor";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(437, 125);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 20);
            this.button7.TabIndex = 16;
            this.button7.Text = "Select from text";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 460);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtCor);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pibMonster);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblProId);
            this.Controls.Add(this.btnSearchPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Rebecca besto waifu";
            ((System.ComponentModel.ISupportInitialize)(this.pibMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchPro;
        private System.Windows.Forms.Label lblProId;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.PictureBox pibMonster;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

