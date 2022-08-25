using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


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
            


            /*if (Array.IndexOf(traits, "") != -1) 
            {

            }*/
            JArray diepercent = (JArray)book["die_probability"];
            JArray dieage = (JArray)book["die_age"];
            int die = (int)diepercent[diepercent.Count-1];
            if (!mode)this.age += 1;
            Random rand = new Random();
            int dicef = rand.Next(0, 100);
            int dis = (int)book["disease"];
            for (int i =0; i< dieage.Count; i++) 
            {
                if (age < (int)dieage[i]) 
                {
                    die = (int)diepercent[i];
                    break;
                }

            }
            foreach(string tra in this.traits) 
            {
                if (tra == null) { continue; }
                die += (int)this.book["trait"][tra];
            }
            if (dicef > die + dis) this.st_die = 2;
            else if (dicef > die) this.st_die = 1;
            else this.st_die = 0;
            this.dicek = dicef;
            return dicef;
        }
       

    }
}
