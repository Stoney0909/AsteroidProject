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
        Player player;
        public CU(Player newPlayer)
        {
            player = newPlayer;
            InitializeComponent();
        }

        private void addHeatlh_Click(object sender, EventArgs e)
        {
            if (player.health < 7)
            {
                player.health ++;
            }
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
