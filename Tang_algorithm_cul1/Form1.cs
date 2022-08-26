using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;



namespace Tang_algorithm_cul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Person> persons_g;
        PersonList lists;
        private void Form1_Load(object sender, EventArgs e)
        {
            turncount.Text = counter.ToString();
            string data_path = @"./data.json";
            string trait_path = @"./trait.json";
            JObject keyValues = new JObject();
            using (StreamReader file2 = File.OpenText(trait_path))
            using (JsonTextReader reader = new JsonTextReader(file2))
            {
                keyValues = (JObject)JToken.ReadFrom(reader);
            }
            using (StreamReader file = File.OpenText(data_path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject json = (JObject)JToken.ReadFrom(reader);
                List<Person> persons = new List<Person>();
                JArray array_a = new JArray();
                array_a = (JArray)json["data"];
                lists = new PersonList(persons);
                foreach (JObject k in array_a)
                {
                    JArray ja = (JArray)k["trait"];
                    Person person =
                        new Person(k["name"].ToString(), (int)k["age"], ja.ToObject<string[]>(), (int)k["die"], keyValues);
                    persons.Add(person);
                }
                persons_g = persons;
                listView.GridLines = true;
                int code = 1;
                foreach (Person human in persons_g)
                {
                    ListViewItem item = new ListViewItem(code.ToString());
                    string tras = "";
                    foreach (string tr in human.traits)
                    {
                        tras += tr + ",";
                    }
                    if (tras.Length > 1) tras = tras.Substring(0, tras.Length - 1);
                    string alive = "";
                    switch (human.st_die)
                    {
                        case 0: alive = "사망"; break;
                        case 1: alive = "병치레"; break;
                        case 2: alive = "생존"; break;
                    }
                    item.SubItems.Add(human.name);
                    item.SubItems.Add(human.age.ToString());
                    item.SubItems.Add(tras);
                    item.SubItems.Add(alive);
                    item.SubItems.Add(human.dicek.ToString());
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

        private void skipbtn_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            listView.BeginUpdate();
            int code = 1;
            foreach (Person per in persons_g) 
            {
                int l = per.dice(false);
                Thread.Sleep(2);
                ListViewItem item = new ListViewItem(code.ToString());
                string tras = "";
                foreach (string tr in per.traits)
                {
                    tras += tr + ",";
                }
                if(tras.Length>0)tras = tras.Substring(0, tras.Length - 1);
                string alive = "";
                switch (per.st_die)
                {
                    case 0: alive = "사망"; break;
                    case 1: alive = "병치레"; break;
                    case 2: alive = "생존"; break;
                }
                item.SubItems.Add(per.name);
                item.SubItems.Add(per.age.ToString());
                item.SubItems.Add(tras);
                item.SubItems.Add(alive);
                item.SubItems.Add(l.ToString());
                listView.Items.Add(item);
                code++;
            }
            listView.EndUpdate();
            counter++;
            turncount.Text = counter.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = "";
            foreach(Person per in persons_g) 
            {
                string alive="";
                string tras = "";
                foreach (string tr in per.traits)
                {
                    tras += tr + ",";
                }
                if(tras.Length>0) tras = tras.Substring(0, tras.Length - 1);
                
                switch (per.st_die)
                {
                    case 0: alive = "사망"; break;
                    case 1: alive = "병치레"; break;
                    case 2: alive = "생존"; break;
                
                }
                st += "이름 : " + per.name + "(나이: " + per.age.ToString() + ") [특성 : " + tras + "] 상황 : "+alive+"/Dice:"+per.dicek+"\n";
            }
            Report page = new Report(st, counter);
            page.Show();
        }
        int counter = 0;

        private void turncount_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            string data_path = @"./data.json";
            if (System.IO.File.Exists(data_path))
            {
                System.IO.File.Delete(data_path);
            }
            JObject returnobj = new JObject();
            JArray returnarr = new JArray();
            foreach(Person per in persons_g)
            {
                JObject persona = new JObject();
                persona.Add("name", per.name.ToString());
                persona.Add("age", per.age.ToString());
                JArray tras = new JArray();
                foreach(string trs in per.traits) 
                {
                    tras.Add(trs);
                }
                persona.Add("trait", tras);
                persona.Add("die", per.st_die.ToString());
                returnarr.Add(persona);
            }
            returnobj.Add("data", returnarr);
            string retu_str = returnobj.ToString();
            System.IO.File.WriteAllText(data_path, retu_str);



        }

        private void settingbtn_Click(object sender, EventArgs e)
        {

        }

        private void selectdice_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem listViewItem in listView.SelectedItems) 
            {
                persons_g[int.Parse(listViewItem.SubItems[0].Text.ToString())-1].dice(true);
                Thread.Sleep(1);
                debug.Text = listViewItem.SubItems[0].Text.ToString();
            }
            listviewupdate();

        }

        private void Add_human_Click(object sender, EventArgs e)
        {
            string trait_path = @"./trait.json";
            JObject keyValues = new JObject();
            using (StreamReader file2 = File.OpenText(trait_path))
            using (JsonTextReader reader = new JsonTextReader(file2))
            {
                keyValues = (JObject)JToken.ReadFrom(reader);
            }
            persons_g.Add(new Person(add_name.Text, int.Parse(add_age.Text), add_tra.Text.Split(','), int.Parse(add_stat.Text), keyValues));
            listView.Items.Clear();
            listView.BeginUpdate();
            int code = 1;
            foreach (Person per in persons_g)
            {
                ListViewItem item = new ListViewItem(code.ToString());
                string tras = "";
                foreach (string tr in per.traits)
                {
                    tras += tr + ",";
                }
                if (tras.Length > 0) tras = tras.Substring(0, tras.Length - 1);
                string alive = "";
                switch (per.st_die)
                {
                    case 0: alive = "사망"; break;
                    case 1: alive = "병치레"; break;
                    case 2: alive = "생존"; break;
                }
                item.SubItems.Add(per.name);
                item.SubItems.Add(per.age.ToString());
                item.SubItems.Add(tras);
                item.SubItems.Add(alive);
                item.SubItems.Add(per.dicek.ToString());
                listView.Items.Add(item);
                code++;
            }
            listView.EndUpdate();
        }

        protected void listviewupdate() 
        {
            listView.Items.Clear();
            listView.BeginUpdate();
            int code = 1;
            foreach (Person per in persons_g)
            {
                ListViewItem item = new ListViewItem(code.ToString());
                string tras = "";
                foreach (string tr in per.traits)
                {
                    tras += tr + ",";
                }
                if (tras.Length > 0) tras = tras.Substring(0, tras.Length - 1);
                string alive = "";
                switch (per.st_die)
                {
                    case 0: alive = "사망"; break;
                    case 1: alive = "병치레"; break;
                    case 2: alive = "생존"; break;
                }
                item.SubItems.Add(per.name);
                item.SubItems.Add(per.age.ToString());
                item.SubItems.Add(tras);
                item.SubItems.Add(alive);
                item.SubItems.Add(per.dicek.ToString());
                listView.Items.Add(item);
                code++;
            }
            listView.EndUpdate();
        }

        private void selDelbtn_Click(object sender, EventArgs e)
        {
            int killed = 1;
            foreach (ListViewItem listViewItem in listView.SelectedItems)
            {
                persons_g.RemoveAt(int.Parse(listViewItem.SubItems[0].Text.ToString())- killed);
                killed += 1;
            }
            listviewupdate();
        }
    }
}
