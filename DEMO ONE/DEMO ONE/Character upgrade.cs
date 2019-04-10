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
    
    public partial class Character_upgrade : Form
    {
        public Player player;
        public Character_upgrade(Player newplayer)
        {
            player = newplayer;
            InitializeComponent();
        }

        private void healthUp_Click(object sender, EventArgs e)
        {

        }

        private void healthDown_Click(object sender, EventArgs e)
        {

        }
    }
}
