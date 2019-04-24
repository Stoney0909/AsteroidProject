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
            InitiliazeComponent();


            /*this.player = player;
            upgrades += 2;

            

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
            NextLevel();*/
        }
        private void addHeatlh_Click(object sender, EventArgs e)
        {
            if(upgrades > 0)
            {
                player.health++;
                minusHealth.Show();
                upgrades--;
                NextLevel();
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
            NextLevel();
        }

        private void addDamage_Click(object sender, EventArgs e)
        {
            if (upgrades > 0)
            {
                player.health += 10;
                minusProDamage.Show();
                upgrades--;
                NextLevel();
            }
        }

        private void addAmountofPro_Click(object sender, EventArgs e)
        {
            if (upgrades > 0)
            {
               player.coolDown -= 10;
               minusAmountOfPro.Show();
               upgrades--;
               NextLevel();
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
            NextLevel();
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
            NextLevel();
        }

        private void minusAmountOfPro_Click(object sender, EventArgs e)
        {
            if (upgrades > 0)
            {
                player.coolDown -= 10;
                addAmountofPro.Show();
                upgrades--;
                NextLevel();
            }
           
        }
        private void NextLevel()
        {
            if (upgrades == 0)
            {
                nextlev.Show();
            }
            else
            {
                nextlev.Hide();
            }
        }

        private void nextlev_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitiliazeComponent()
        {
            this.SuspendLayout();
            // 
            // CU
            // 
            this.ClientSize = new System.Drawing.Size(861, 513);
            this.Name = "CU";
            this.ResumeLayout(false);

        }
    }
}
