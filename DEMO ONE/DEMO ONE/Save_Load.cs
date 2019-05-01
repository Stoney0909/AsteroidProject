using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DEMO_ONe
{
    public class Save_Load
    {
        public double score;
        public string name;

        public Save_Load(string path, int account) //the following is for loading:
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            name = lines[account].Split(':')[0];
            string inputscore = lines[account].Split(':')[1];
            score = double.Parse(inputscore);
        }

        public Save_Load(string name, double score) //constructor:
        {
            this.name = name;
            this.score = score;
        }

        public void resetVals () //reset 
        {
            name = null;
            score = 0;
        }

        public void saveFile (string path) //save file
        {
            string[] lines = { name + ":" + score };
            File.AppendAllLines(path, lines);
        }

        public void clearFile (string path) //clear file
        {
            string[] empty = {};
            File.WriteAllLines(path, empty);
        }

        public void organize (List<Save_Load> rankScores) //orders the top ten scores
        {
            Save_Load player = new Save_Load(name, score);
            for(int i = 0; i < 10; i++)
            {
                if (score > rankScores[i].score)
                {
                    rankScores.Insert(i, player);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
