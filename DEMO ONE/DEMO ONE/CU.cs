using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DEMO_ONe.Content.Players;
using DEMO_ONe.Content.States;

namespace DEMO_ONe
{
    public partial class CU : Form
    {
        int upgrades;
        Player player;
        public CU(Player player)
        {
            this.player = player;
            upgrades += 2;
            InitializeComponent();
            healthTextBox.Text = player.health.ToString();
            damageTextBox.Text = player.damage.ToString();
            ProTextBox.Text = player.coolDown.ToString();
            if(player.health == 1)
            {
                minusHealth.Hide();
            }
            if(player.damage == 10)
            {
                minusProDamage.Hide();
            }
            if (player.coolDown == 10)
            {
                addAmountofPro.Hide();
            }
        }
        private void addHeatlh_Click(object sender, EventArgs e)
        {
            if(upgrades > 0)
            {
                player.health++;
                minusHealth.Show();
            }
        }

        private void addSpeed_Click(object sender, EventArgs e)
        {
            player.coolDown -= 5;
            upgrades++;
            if (player.coolDown == 2)
            {
                addAmountofPro.Hide();
            }
        }

        private void addDamage_Click(object sender, EventArgs e)
        {
            if (upgrades > 0)
            {
                player.health += 10;
                minusProDamage.Show();
            }
        }

        private void addAmountofPro_Click(object sender, EventArgs e)
        {
            if (upgrades > 0)
            {
               player.coolDown -= 10;
                minusAmountOfPro.Show();
            }
        }

        private void minusHealth_Click(object sender, EventArgs e)
        {
                player.health -= 1;
                upgrades++;
            if (player.health == 1)
            {
                minusHealth.Hide();
            }
        }

        private void minusShipSpeed_Click(object sender, EventArgs e)
        {

        }

        private void minusProDamage_Click(object sender, EventArgs e)
        {
            player.damage -= 10;
            upgrades++;
            if (player.damage == 10)
            {
                minusProDamage.Hide();
            }
        }

        private void minusAmountOfPro_Click(object sender, EventArgs e)
        {
            if (upgrades > 0)
            {
                player.coolDown -= 10;
                addAmountofPro.Show();
            }
           
        }
        private void NextLevel()
        {
            if (upgrades == 0)
            {
                nextlev.Show();
            }
        }

        private void nextlev_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
