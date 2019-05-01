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
        public float health = 0;
        public int coolDown = 0;
        public double money = 0;
        public CharacterUpgrade(float health, int coolDown, double money)
        {
            this.health = health;
            this.coolDown = coolDown;
            this.money = money;

            InitializeComponent();
        }

        private void addhealth_Click(object sender, EventArgs e)
        {
            if (money >= 300)
            {
                health++;

                money -= 20;
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
                addcoolDown.Show();
                money -= 20;
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
