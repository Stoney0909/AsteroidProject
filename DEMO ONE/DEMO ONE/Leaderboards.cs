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
    public partial class Leaderboards : Form
    {
        List<Save_Load> topScoreList = new List<Save_Load> { };
        public Leaderboards()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Save_Load account = new Save_Load("top scores.txt", i);
                topScoreList.Insert(i, account);
                
            }
            name1.Text = topScoreList[0].name;
            name2.Text = topScoreList[1].name;
            name3.Text = topScoreList[2].name;
            name4.Text = topScoreList[3].name;
            name5.Text = topScoreList[4].name;
            name6.Text = topScoreList[5].name;
            name7.Text = topScoreList[6].name;
            name8.Text = topScoreList[7].name;
            name9.Text = topScoreList[8].name;
            name10.Text = topScoreList[9].name;
            score1.Text = topScoreList[0].score.ToString();
            score2.Text = topScoreList[1].score.ToString();
            score3.Text = topScoreList[2].score.ToString();
            score4.Text = topScoreList[3].score.ToString();
            score5.Text = topScoreList[4].score.ToString();
            score6.Text = topScoreList[5].score.ToString();
            score7.Text = topScoreList[6].score.ToString();
            score8.Text = topScoreList[7].score.ToString();
            score9.Text = topScoreList[8].score.ToString();
            score10.Text = topScoreList[9].score.ToString();

            //topScoreList.elementat(i).score

        }



        private void button1_Click(object sender, EventArgs e) //main menu
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //instructions
        {
            this.Hide();
            HowToPlay Form1 = new HowToPlay();
            Form1.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
