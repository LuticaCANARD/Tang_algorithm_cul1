namespace Tang_algorithm_cul1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.skipbtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.turncount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_human = new System.Windows.Forms.Button();
            this.settingbtn = new System.Windows.Forms.Button();
            this.selectdice = new System.Windows.Forms.Button();
            this.add_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_tra = new System.Windows.Forms.TextBox();
            this.add_stat = new System.Windows.Forms.TextBox();
            this.add_age = new System.Windows.Forms.TextBox();
            this.debug = new System.Windows.Forms.Label();
            this.selDelbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.dataview = new System.Windows.Forms.Integration.ElementHost();
            this.dataview21 = new Tang_algorithm_cul1.dataview2();
            this.SuspendLayout();
            // 
            // skipbtn
            // 
            this.skipbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skipbtn.Location = new System.Drawing.Point(904, 621);
            this.skipbtn.Margin = new System.Windows.Forms.Padding(4);
            this.skipbtn.Name = "skipbtn";
            this.skipbtn.Size = new System.Drawing.Size(107, 34);
            this.skipbtn.TabIndex = 16;
            this.skipbtn.Text = "넘기기";
            this.skipbtn.UseVisualStyleBackColor = true;
            this.skipbtn.Click += new System.EventHandler(this.skipbtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.loadbtn.Location = new System.Drawing.Point(1020, 618);
            this.loadbtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(99, 36);
            this.loadbtn.TabIndex = 17;
            this.loadbtn.Text = "저장";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(789, 621);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "보고서";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turncount
            // 
            this.turncount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.turncount.Location = new System.Drawing.Point(361, 621);
            this.turncount.Name = "turncount";
            this.turncount.ReadOnly = true;
            this.turncount.Size = new System.Drawing.Size(100, 28);
            this.turncount.TabIndex = 4;
            this.turncount.TextChanged += new System.EventHandler(this.turncount_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 624);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "턴수";
            // 
            // Add_human
            // 
            this.Add_human.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Add_human.AutoSize = true;
            this.Add_human.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Add_human.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Add_human.Location = new System.Drawing.Point(1020, 580);
            this.Add_human.Name = "Add_human";
            this.Add_human.Size = new System.Drawing.Size(96, 28);
            this.Add_human.TabIndex = 12;
            this.Add_human.Text = "사람 추가";
            this.Add_human.UseVisualStyleBackColor = false;
            this.Add_human.Click += new System.EventHandler(this.Add_human_Click);
            // 
            // settingbtn
            // 
            this.settingbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.settingbtn.Location = new System.Drawing.Point(575, 620);
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(100, 34);
            this.settingbtn.TabIndex = 13;
            this.settingbtn.Text = "설정 조작";
            this.settingbtn.UseVisualStyleBackColor = true;
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // selectdice
            // 
            this.selectdice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.selectdice.Location = new System.Drawing.Point(681, 620);
            this.selectdice.Name = "selectdice";
            this.selectdice.Size = new System.Drawing.Size(101, 34);
            this.selectdice.TabIndex = 14;
            this.selectdice.Text = "선택굴림";
            this.selectdice.UseVisualStyleBackColor = true;
            this.selectdice.Click += new System.EventHandler(this.selectdice_Click);
            // 
            // add_name
            // 
            this.add_name.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_name.Location = new System.Drawing.Point(98, 586);
            this.add_name.Name = "add_name";
            this.add_name.Size = new System.Drawing.Size(120, 28);
            this.add_name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(852, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "상태";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "특성목록";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "나이";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "이름";
            // 
            // add_tra
            // 
            this.add_tra.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_tra.Location = new System.Drawing.Point(467, 586);
            this.add_tra.Name = "add_tra";
            this.add_tra.Size = new System.Drawing.Size(379, 28);
            this.add_tra.TabIndex = 10;
            this.add_tra.TextChanged += new System.EventHandler(this.add_tra_TextChanged);
            // 
            // add_stat
            // 
            this.add_stat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_stat.Location = new System.Drawing.Point(911, 585);
            this.add_stat.Name = "add_stat";
            this.add_stat.Size = new System.Drawing.Size(100, 28);
            this.add_stat.TabIndex = 11;
            // 
            // add_age
            // 
            this.add_age.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add_age.Location = new System.Drawing.Point(275, 589);
            this.add_age.Name = "add_age";
            this.add_age.Size = new System.Drawing.Size(100, 28);
            this.add_age.TabIndex = 9;
            // 
            // debug
            // 
            this.debug.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(38, 637);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(54, 18);
            this.debug.TabIndex = 18;
            this.debug.Text = "label6";
            // 
            // selDelbtn
            // 
            this.selDelbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.selDelbtn.Location = new System.Drawing.Point(467, 621);
            this.selDelbtn.Name = "selDelbtn";
            this.selDelbtn.Size = new System.Drawing.Size(102, 33);
            this.selDelbtn.TabIndex = 19;
            this.selDelbtn.Text = "선택삭제";
            this.selDelbtn.UseVisualStyleBackColor = true;
            this.selDelbtn.Click += new System.EventHandler(this.selDelbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(0, 547);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1020, 547);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 27);
            this.button2.TabIndex = 22;
            this.button2.Text = "변경 저장";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataview
            // 
            this.dataview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataview.Location = new System.Drawing.Point(-4, 0);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(1123, 541);
            this.dataview.TabIndex = 21;
            this.dataview.TabStop = false;
            this.dataview.Text = "elementHost1";
            this.dataview.ChildChanged += new System.EventHandler<System.Windows.Forms.Integration.ChildChangedEventArgs>(this.dataview_ChildChanged);
            this.dataview.Child = this.dataview21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 667);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.selDelbtn);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.add_age);
            this.Controls.Add(this.add_stat);
            this.Controls.Add(this.add_tra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.add_name);
            this.Controls.Add(this.selectdice);
            this.Controls.Add(this.settingbtn);
            this.Controls.Add(this.Add_human);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turncount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.skipbtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button skipbtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox turncount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_human;
        private System.Windows.Forms.Button settingbtn;
        private System.Windows.Forms.Button selectdice;
        private System.Windows.Forms.TextBox add_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_tra;
        private System.Windows.Forms.TextBox add_stat;
        private System.Windows.Forms.TextBox add_age;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.Button selDelbtn;
        private System.Windows.Forms.Panel panel1;
        private dataview2 dataview21;
        private System.Windows.Forms.Integration.ElementHost dataview;
        private System.Windows.Forms.Button button2;
    }
}

