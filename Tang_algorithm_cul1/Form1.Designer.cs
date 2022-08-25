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
            this.listView = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namecoulm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Agecoulm = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.traitlist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.turncount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // skipbtn
            // 
            this.skipbtn.Location = new System.Drawing.Point(903, 622);
            this.skipbtn.Margin = new System.Windows.Forms.Padding(4);
            this.skipbtn.Name = "skipbtn";
            this.skipbtn.Size = new System.Drawing.Size(107, 34);
            this.skipbtn.TabIndex = 0;
            this.skipbtn.Text = "넘기기";
            this.skipbtn.UseVisualStyleBackColor = true;
            this.skipbtn.Click += new System.EventHandler(this.skipbtn_Click);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(1019, 622);
            this.loadbtn.Margin = new System.Windows.Forms.Padding(4);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(107, 34);
            this.loadbtn.TabIndex = 1;
            this.loadbtn.Text = "저장";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // listView
            // 
            this.listView.AllowColumnReorder = true;
            this.listView.AllowDrop = true;
            this.listView.BackgroundImageTiled = true;
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.Namecoulm,
            this.Agecoulm,
            this.traitlist,
            this.stat,
            this.dice});
            this.listView.HideSelection = false;
            this.listView.HoverSelection = true;
            this.listView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(17, 41);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(1109, 571);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // number
            // 
            this.number.Text = "순번";
            // 
            // Namecoulm
            // 
            this.Namecoulm.Text = "이름";
            this.Namecoulm.Width = 224;
            // 
            // Agecoulm
            // 
            this.Agecoulm.Text = "나이";
            // 
            // traitlist
            // 
            this.traitlist.Text = "특성 목록";
            this.traitlist.Width = 324;
            // 
            // stat
            // 
            this.stat.Text = "상태";
            this.stat.Width = 103;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(788, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "보고서";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turncount
            // 
            this.turncount.Location = new System.Drawing.Point(1019, 6);
            this.turncount.Name = "turncount";
            this.turncount.ReadOnly = true;
            this.turncount.Size = new System.Drawing.Size(100, 28);
            this.turncount.TabIndex = 4;
            this.turncount.TextChanged += new System.EventHandler(this.turncount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(959, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "턴수";
            // 
            // dice
            // 
            this.dice.Text = "dice";
            this.dice.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.turncount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.skipbtn);
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
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader Namecoulm;
        private System.Windows.Forms.ColumnHeader Agecoulm;
        private System.Windows.Forms.ColumnHeader traitlist;
        private System.Windows.Forms.ColumnHeader stat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox turncount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader dice;
    }
}

