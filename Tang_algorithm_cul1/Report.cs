using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tang_algorithm_cul1
{
    public partial class Report : Form
    {
        string report_con;
        string count;
        public Report(string report_con_,int count)
        {
            InitializeComponent();
            this.report_con = report_con_;
            this.count = count.ToString();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            Report_text.ReadOnly = true;
            Report_text.Text = "count : "+count+"\n"+report_con;
            Report_text.Show();
        }
    }
}
