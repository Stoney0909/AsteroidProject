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

namespace DEMO_ONe
{
    public partial class CU : Form
    {
        int health, damage, coolDown;
        float maxVel;
        bool upgraded;
        public CU(int newHealth, int newDamage, float newMaxVel, int newCoolDown)
        {
            health = newHealth;
            damage = newDamage;
            maxVel = newMaxVel;
            coolDown = newCoolDown;
            
            InitializeComponent();
        }
        public bool isUpgraded()
        {
            if (upgraded)
            {
                return true;
            }
            return false;
        }
        private void addHeatlh_Click(object sender, EventArgs e)
        {
            
        }

        private void addSpeed_Click(object sender, EventArgs e)
        {

        }

        private void addDamage_Click(object sender, EventArgs e)
        {

        }

        private void addAmountofPro_Click(object sender, EventArgs e)
        {

        }

        private void minusHealth_Click(object sender, EventArgs e)
        {

        }

        private void minusShipSpeed_Click(object sender, EventArgs e)
        {

        }

        private void minusProDamage_Click(object sender, EventArgs e)
        {

        }

        private void minusAmountOfPro_Click(object sender, EventArgs e)
        {

        }
    }
}
