using DEMO_ONe.Content.Players;
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
    public partial class CharacterUpgrade : Form
    {
        Player player;

        public CharacterUpgrade(Player player)
        {
            this.player = player;

            InitializeComponent();
        }

        private void addhealth_Click(object sender, EventArgs e)
        {
            if (player.money >= 300)
            {
                player.health += 1;
                player.money -= 300;
            }
            else
            {
                error.Show();
            }

        }

        private void addcoolDown_Click(object sender, EventArgs e)
        {
            if (player.money >= 300)
            {
                player.coolDown -= 10;
                player.money -= 300;
            }
            else
            {
                error.Show();
            }
        }



        private void continuebutton_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

    }
}
