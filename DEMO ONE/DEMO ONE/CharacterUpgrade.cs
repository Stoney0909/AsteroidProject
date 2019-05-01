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
        public float health;
        public int coolDown;
        public double money;

        public CharacterUpgrade(Player player)
        {
            health = player.health;
            coolDown = player.coolDown;
            money = player.money;

            InitializeComponent();
        }

        private void addhealth_Click(object sender, EventArgs e)
        {
            if (money >= 300)
            {
                health+=1;
                money -= 300;
            }
            else
            {
                error.Show();
            }

        }

        private void addcoolDown_Click(object sender, EventArgs e)
        {
            if (money >= 300)
            {
                coolDown -= 10;
                money -= 300;
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
