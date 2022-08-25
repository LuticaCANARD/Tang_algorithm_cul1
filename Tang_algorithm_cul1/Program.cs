using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    public class Person 
    {
        public string name;
        public int age;
        public string[] traits;
        public int st_die;
        public Person(string _name, int _age , string[] _trait,int _st_die) 
        { 
            this.name=_name;
            this.traits=_trait;
            this.age = _age;
            this.st_die = _st_die;
        }
        public void dice()
        {
            int age = 33;
            int die;
            Random rand = new Random();
            int dicef = rand.Next(0, 100);
            if (age < 55) die = 5;
            else if (age < 75) die = (age - 54) * 3;
            else die = 65;

            if (dicef < die - 10) this.st_die = 2;
            else if (dicef < die) this.st_die = 1;
            else this.st_die = 0;
        }
       

    }
}
