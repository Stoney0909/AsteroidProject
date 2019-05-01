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
        public float money;
        public CU(Player player)
        {
            InitiliazeComponent();


            this.player = player;
            upgrades += 2;

            

            healthTextBox.Text = player.health.ToString();
            damageTextBox.Text = player.damage.ToString();
            ProTextBox.Text = player.coolDown.ToString();
            moneylabel.Text = player.money.ToString();
            updateButtons();
        }
        private void addHeatlh_Click(object sender, EventArgs e)
        {
            if(upgrades > 0)
            {
                player.health++;
                minusHealth.Show();
                money -= 20;
                NextLevel();
            }
        }

        private void addDamage_Click(object sender, EventArgs e)
        {
            if (money > 20)
            {
                player.health += 10;
                minusProDamage.Show();
                money -= 10;
                NextLevel();
            }
        }

        private void addAmountofPro_Click(object sender, EventArgs e)
        {
            if (money > 20)
            {
               player.coolDown -= 10;
               minusAmountOfPro.Show();
               money -=20;
               NextLevel();
            }
         
        }

        private void minusHealth_Click(object sender, EventArgs e)
        {
                player.health -= 1;
                money += 10;
            if (player.health == 1)
            {
                minusHealth.Hide();
                updateButtons();
            }
            NextLevel();
        }

        private void minusShipSpeed_Click(object sender, EventArgs e)
        {

        }

        private void minusProDamage_Click(object sender, EventArgs e)
        {
            player.damage -= 10;
            money += 10;
            if (player.damage == 10)
            {
                minusProDamage.Hide();
                updateButtons();
            }
            NextLevel();
        }

        private void minusAmountOfPro_Click(object sender, EventArgs e)
        {
            if (money > 20)
            {
                player.coolDown -= 10;
                addAmountofPro.Show();
                money -= 20;
                NextLevel();
                updateButtons();
            }
           
        }
        private void NextLevel()
        { 
                nextlev.Show();
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
        private void updateButtons()
        {
            if (player.health == 1)
            {
                minusHealth.Hide();
            }
            else
            {
                minusHealth.Show();
            }
            if (player.damage == 10)
            {
                minusProDamage.Hide();
            }
            
            if (player.coolDown == 10)
            {
                addAmountofPro.Hide();
            }
            else
            {
                addAmountofPro.Show();
            }
            moneylabel.Text = money.ToString();
            NextLevel();

        }
    }
}
