using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;


namespace Tang_algorithm_cul1
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class PersonList : ObservableCollection<Person> 
    { 
        public PersonList(List<Person>persons) 
        {
            foreach(Person person in persons) 
            {
                Add(person);
            }
        }
    }
    public class Person 
    {
        public string name { get; set; }
        public int age { get; set; }
        public string[] traits { get; set; }
        public int st_die { get; set; }
        public JObject book { get; set; }
        public int dicek { get; set; }

        public Person(string _name, int _age , string[] _trait,int _st_die,JObject keyValues) 
        { 
            this.name=_name;
            this.traits=_trait;
            this.age = _age;
            this.st_die = _st_die;
            this.book = keyValues;
        }
        public int dice(bool mode)
        {
            if (this.st_die == 0 && !mode) return 0 ;
            int age = this.age;
            Random rand = new Random();
            
            int dis = (int)book["disease"];
            JArray diepercent = (JArray)book["die_probability"];
            JArray dieage = (JArray)book["die_age"];
            JObject trait = (JObject)book["trait"];
            int die = (int)diepercent[diepercent.Count-1];

            int dicef;

            if (age<(int)book["dice_age"]) 
            { 
                int dice1v = rand.Next(1, 100);
                 Thread.Sleep(1);
                int dice2v = rand.Next(1, 100);
                  dicef = Math.Max(dice1v, dice2v); 
            } 
            else
            { dicef = rand.Next(0, 1000);}
            int diseases = 0;
            int dis_count = 1;
            foreach (string tra in this.traits)
            {
                if (trait[tra] != null)
                {
                    JObject tra_obj = (JObject)trait[tra];
                    if (tra_obj["type"].ToString() == "unique")
                    {
                        if (tra_obj["die_age"] != null)
                        {
                            dieage = (JArray)tra_obj["die_age"];
                            diepercent = (JArray)tra_obj["die_probability"];
                            die = (int)diepercent[diepercent.Count - 1];

                        }
                        if (tra_obj["disease"] != null)
                        {
                            diseases += int.Parse(tra_obj["disease"].ToString());
                            dis_count++;

                        }
                        if (tra_obj["death_p"] != null)
                        {
                            die += (int)tra_obj["death_p"];
                        }
                    }
                    else
                    {
                        if (tra_obj["death_p"] != null)
                        {
                            die += (int)tra_obj["death_p"];
                        }
                    }
                }
            }
            dis = (dis+diseases) *  / dis_count;


            if (!mode)this.age += 1;

            for (int i =0; i< dieage.Count; i++) 
            {
                if (age < (int)dieage[i]) 
                {
                    die = (int)diepercent[i];
                    break;
                }

            }
            if (dicef > die + dis) this.st_die = 2;
            else if (dicef > die) this.st_die = 1;
            else this.st_die = 0;
            this.dicek = dicef;
            return dicef;
        }
       

    }
}
