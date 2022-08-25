using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace Tang_algorithm_cul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> persons_g;
        private void Form1_Load(object sender, EventArgs e)
        {
            string data_path = @"./data.json";
            using (StreamReader file= File.OpenText(data_path))
            using(JsonTextReader reader= new JsonTextReader(file)) 
            {
                JObject json = (JObject)JToken.ReadFrom(reader);
                List<Person> persons = new List<Person>();
                JArray array_a = new JArray();
                array_a = (JArray)json["data"];
                foreach(JObject k in array_a) 
                {
                    JArray ja = (JArray)k["trait"];
                    Person person = 
                        new Person(k["name"].ToString(),(int)k["age"], ja.ToObject<string[]>(),(int)k["die"]);
                    persons.Add(person);
                }
                persons_g = persons;
                listView.GridLines = true;
                int code = 1;
                foreach(Person human in persons_g) 
                {
                    ListViewItem item = new ListViewItem(code.ToString());
                    string tras = "";
                    foreach (string tr in human.traits)
                    {
                        tras += tr + ",";
                    }
                    tras = tras.Substring(0, tras.Length- 1);
                    string alive = "";
                    switch (human.st_die) 
                    {
                        case 0:alive = "사망";break;
                        case 1: alive = "병치레"; break;
                        case 2: alive = "생존"; break;
                    }
                    item.SubItems.Add(human.name);
                    item.SubItems.Add(human.age.ToString());
                    item.SubItems.Add(tras);
                    item.SubItems.Add(alive);
                    listView.Items.Add(item);
                    code++;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
