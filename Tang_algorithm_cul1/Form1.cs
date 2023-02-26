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
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static System.IO.Directory;



namespace Tang_algorithm_cul1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // 이하는 신형
        List<showHuman> person_gg = new List<showHuman>() { };

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
                person_gg.AddRange(from JObject k in array_a
                                   let ja = (JArray)k["trait"]
                                   let person =
                    new Person(k["name"].ToString(), (int)k["age"], ja.ToObject<string[]>(), (int)k["die"], keyValues, "")
                                   let human = new showHuman(person)
                                   select human);
            }
            dataview21.maingridcon.ItemsSource = person_gg;
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
            foreach (showHuman human in person_gg)
            {
                human.dice(false);
            }
            listviewupdate();
            counter++;
            turncount.Text = counter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = "";
            foreach (showHuman per in person_gg)
            {
                string alive = "";
                string tras = "";
                foreach (string tr in per.original.traits)
                {
                    tras += tr + ",";
                }
                if (tras.Length > 0) tras = tras.Substring(0, tras.Length - 1);

                switch (per.original.st_die)
                {
                    case 0: alive = "사망"; break;
                    case 1: alive = "병치레"; break;
                    case 2: alive = "생존"; break;

                }
                st += "이름 : " + per.name + "(나이: " + per.age.ToString() + ") [특성 : " + tras + "] 상황 : " + alive + "/Dice:" + per.dicek + "\n";
            }
            Report page = new Report(st, counter);
            page.Show();
        }
        int counter = 1901;

        private void turncount_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            // 저장이다.
            string data_path = @"./data.json";
            if (System.IO.File.Exists(data_path))
            {
                System.IO.File.Delete(data_path);
            }
            JObject returnobj = new JObject();
            JArray returnarr = new JArray();
            foreach (showHuman human in person_gg)
            {
                Person per = human.original;
                JObject persona = new JObject
                {
                    { "name", per.name.ToString() },
                    { "age", per.age.ToString() }
                };
                JArray tras = new JArray();
                foreach (string trs in per.traits)
                {
                    tras.Add(trs);
                }
                persona.Add("trait", tras);
                persona.Add("die", per.st_die.ToString());
                persona.Add("agent", per.agent);
                returnarr.Add(persona);
            }
            returnobj.Add("data", returnarr);
            string retu_str = returnobj.ToString();
            System.IO.File.WriteAllText(data_path, retu_str);
            string now_route = @"./logs/data_" +DateTime.Now.ToString("yyyyMMddHHmmss")+".json";
            if (!Exists(@"./logs"))
            {
                CreateDirectory(@"./logs");
            }
            System.IO.File.WriteAllText(now_route, retu_str);


        }

        private void settingbtn_Click(object sender, EventArgs e)
        {

        }

        private void selectdice_Click(object sender, EventArgs e)
        {
            foreach(showHuman human in dataview21.maingridcon.SelectedItems) 
            {
                human.dice(true);
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
            Person per=new Person(add_name.Text, int.Parse(add_age.Text), add_tra.Text.Split(','), int.Parse(add_stat.Text), keyValues,"");
            showHuman human = new showHuman(per);
            person_gg.Add(human);
            listviewupdate();
        }

        protected void listviewupdate()
        {
            dataview21.maingridcon.ItemsSource = null ;
            dataview21.maingridcon.ItemsSource = person_gg;
        }

        private void selDelbtn_Click(object sender, EventArgs e)
        {
            foreach (showHuman human in dataview21.maingridcon.SelectedItems)
            {
                person_gg.Remove(human);
            }
            listviewupdate();
        }

        private void add_tra_TextChanged(object sender, EventArgs e)
        {

        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
        public class showHuman
        {
            public string name { get; set; }
            public string age { get; set; }
            public string traits { get; set; }
            public string st_die { get; set; }
            public string dicek { get; set; }
            public Person original { get; set; }
            public string agent { get; set; }

            public showHuman(Person per)
            {
                this.traits ="";
                foreach(string tra in per.traits) 
                {
                    this.traits += tra + ",";
                }
                this.traits = traits.TrimEnd(',');
                this.name = per.name;
                this.age = per.age.ToString();
                this.agent = per.agent;
                switch (per.st_die) 
                {
                    case 0: this.st_die = "사망";break;
                    case 1: this.st_die = "병치레";break;
                    case 2: this.st_die = "건강";break;
                }
                this.dicek = per.dicek.ToString();
                this.original = per;
            }
            public void dice(bool mode) 
            {
                this.original.dice(mode);
                this.age = this.original.age.ToString();
                switch (this.original.st_die)
                {
                    case 0: this.st_die = "사망"; break;
                    case 1: this.st_die = "병치레"; break;
                    case 2: this.st_die = "건강"; break;
                }
                this.dicek = this.original.dicek.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 여기에서 상태 역변환
            foreach(showHuman show in person_gg) 
            {
                show.original.traits = show.traits.Split(',');
                show.original.name = show.name;
                show.original.age = int.Parse(show.age);
                show.original.dicek = int.Parse(show.dicek);
                show.original.agent = show.agent;
                switch (show.st_die) 
                {
                    case "사망": show.original.st_die = 0;  break;
                    case "병치레": show.original.st_die = 1; break;
                    case "건강": show.original.st_die = 2; break;
                    default:MessageBox.Show(show.name+"의 상태 문자열이 이상합니다. \n 사망/건강/병치레 셋중 하나만 입력하십시오", "ERROR!"); break;
                }
            }
            listviewupdate();
        }

        private void dataview_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //지정된 파일에서 불러오기
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            ofd.Title = "파일 오픈 예제창";
            ofd.FileName = "test";
            ofd.Filter = "로그 (*.json) | *.json; | 모든 파일 (*.*) | *.*";

            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                string trait_path = @"./trait.json";
                JObject keyValues = new JObject();
                using (StreamReader file2 = File.OpenText(trait_path))
                using (JsonTextReader reader = new JsonTextReader(file2))
                {
                    keyValues = (JObject)JToken.ReadFrom(reader);
                }
                string loaded_path = ofd.FileName;
                using (StreamReader file = File.OpenText(loaded_path))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject json = (JObject)JToken.ReadFrom(reader);
                    List<Person> persons = new List<Person>();
                    JArray array_a = new JArray();
                    array_a = (JArray)json["data"];
                    lists = new PersonList(persons);
                    person_gg.AddRange(from JObject k in array_a
                                       let ja = (JArray)k["trait"]
                                       let person =
                        new Person(k["name"].ToString(), (int)k["age"], ja.ToObject<string[]>(), (int)k["die"], keyValues, "")
                                       let human = new showHuman(person)
                                       select human);
                }
                dataview21.maingridcon.ItemsSource = person_gg;
            }
            else
            {
                return;
            }

            
        }
    }
}
