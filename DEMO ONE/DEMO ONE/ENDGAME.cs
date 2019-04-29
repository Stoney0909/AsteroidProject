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
    public partial class ENDGAME : Form
    {
        List<Save_Load> listOfPlayers;
        Save_Load player;

        public ENDGAME(Save_Load player)
        {
            this.player = player;
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Save_Load account = new Save_Load("top scores", i);
                listOfPlayers.Insert(i, account);
            }
            this.player.organize(listOfPlayers);
            for (int i = 0; i < listOfPlayers.Count; i++)
            {
                listOfPlayers.ElementAt(i).saveFile("top scores");
            }
        }

        private void button1_Click(object sender, EventArgs e) // main menu
        {

        }

        private void button2_Click(object sender, EventArgs e) //top ten
        {

        }
    }
}
