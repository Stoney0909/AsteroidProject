﻿using System;
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
    public partial class HOWTOPLAY : Form
    {
        public HOWTOPLAY()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // back to main menu
        {
            this.Hide();
            MainMenu Form1 = new MainMenu();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) // to the top ten
        {
            this.Hide();
            Leaderboards Form1 = new Leaderboards();
            Form1.ShowDialog();
            this.Close();
        }
    }
}
