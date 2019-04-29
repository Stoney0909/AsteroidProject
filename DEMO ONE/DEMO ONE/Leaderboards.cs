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
        List<Save_Load> topScoreList;
        public Leaderboards()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Save_Load account = new Save_Load("top scores", i);
                topScoreList.Insert(i, account);
                
            }

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
    }
}
