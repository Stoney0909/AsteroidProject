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
        private bool game = false;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //player name input
        {

        }

        private void button1_Click(object sender, EventArgs e) //new game
        {
            Validators myForm = new Validators(name.Text);

            if (myForm.nameValidator() == false)//first name error
            {
                game = false;
                MessageBox.Show("Please enter a valid name");
            }
            game = true;
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //the top ten
        {
            this.Hide();   
            Leaderboards Form1 = new Leaderboards();
            Form1.ShowDialog();
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e) //instructions
        {
            this.Hide()
        }
        public bool startGame()
        {
            return game;
        }
    }
}
