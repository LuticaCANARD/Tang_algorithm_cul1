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
            this.SuspendLayout();
            // 
            // skipbtn
            // 
            this.skipbtn.Location = new System.Drawing.Point(632, 415);
            this.skipbtn.Name = "skipbtn";
            this.skipbtn.Size = new System.Drawing.Size(75, 23);
            this.skipbtn.TabIndex = 0;
            this.skipbtn.Text = "넘기기";
            this.skipbtn.UseVisualStyleBackColor = true;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(713, 415);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(75, 23);
            this.loadbtn.TabIndex = 1;
            this.loadbtn.Text = "불러오기";
            this.loadbtn.UseVisualStyleBackColor = true;
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
            this.stat});
            this.listView.HoverSelection = true;
            this.listView.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.ShowItemToolTips = true;
            this.listView.Size = new System.Drawing.Size(776, 397);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.skipbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

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
    }
}

