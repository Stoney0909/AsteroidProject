using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_ONe
{
    public partial class Form1 : Form
    {
        private string name;
        private double score;
        private bool game = false;
        public Form1(string newName = "NONAME", double newScore=0)
        {
            name = newName;
            score = newScore;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //player name input
        {
            name = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e) //new game
        {
       
            Validators myValidators = new Validators(name, score);


            if (myValidators.nameValidator() == false || name == "NONAME")//name error
            {
               // game = false;
                MessageBox.Show("Please enter a name between 3-12 characters");
            }
            else
            {
                game = true;
                this.Hide();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) //the top ten
        {
            this.Hide();
            Leaderboards Form1 = new Leaderboards();
            Form1.ShowDialog();
            this.Show();
            
        }

        private void button3_Click(object sender, EventArgs e) //instructions
        {
           this.Hide();
            HowToPlay Form1 = new HowToPlay();
            Form1.ShowDialog();
            this.Show();
        }
        public bool startGame()
        {
            return game;
        }
    }
}
