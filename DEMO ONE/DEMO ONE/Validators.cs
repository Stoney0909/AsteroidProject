using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_ONe
{
    public class Validators
    {
        public string name;
        public double score;

        //constructor:
        public Validators(string newName, double newScore)
        {
            name = newName;
            score = newScore;

        }

        public bool nameValidator()
        {
            if (name.Length < 3 || name.Length > 12)//checks size
            {
                return false;
            }
            return true;
        }

       
        public Validators(string path)
        {
            
            string[] lines;
            lines = File.ReadAllLines(path);
            name = lines[0].Split(':')[1].Split(' ')[0];
            score = double.Parse(lines[0].Split(':')[1].Split(' ')[1]);

        }
    }
}
