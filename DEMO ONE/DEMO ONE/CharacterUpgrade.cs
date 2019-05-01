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
        public CharacterUpgrade(float health, int coolDown, double money)
        {
            this.health = health;
            this.coolDown = coolDown;
            this.money = money;
            HealthTextBox.Text = health.ToString();
            ProTextBox.Text = coolDown.ToString();
            totalmoney.Text = money.ToString();
            updateButtons();
            InitializeComponent();
        }

        private void addhealth_Click(object sender, EventArgs e)
        {
            if (money >= 20)
            {
                health++;
                minusHealth.Show();
                money -= 20;
            }
            updateButtons();
        }

        private void addcoolDown_Click(object sender, EventArgs e)
        {
            if (money >= 20)
            {
                coolDown -= 10;
                minusAmountofPro.Show();
                money -= 20;
            }
            updateButtons();
        }

        private void minusHealth_Click(object sender, EventArgs e)
        {
            health -= 1;
            money += 10;
            if (health == 1)
            {
                minusHealth.Hide();
                updateButtons();
            }
            updateButtons();
        }

        private void minusAmountofPro_Click(object sender, EventArgs e)
        {
            if (money >= 20)
            {
                coolDown -= 10;
                addcoolDown.Show();
                money -= 20;
                updateButtons();
            }
        }

        private void continuebutton_Click(object sender, EventArgs e)
        {

        }
        private void updateButtons()
        {
            //HealthTextBox.Text = health.ToString();
            //ProTextBox.Text = coolDown.ToString();
            //totalmoney.Text = money.ToString();
            //if (health == 1)
            //{
            //    minusHealth.Hide();
            //}
            //else
            //{
            //    minusHealth.Show();
            //}

            //if (coolDown == 10)
            //{
            //    addcoolDown.Hide();
            //}
            //else
            //{
            //    minusHealth.Show();
            //}
            //totalmoney.Text = money.ToString();
  

        }

    }
}
