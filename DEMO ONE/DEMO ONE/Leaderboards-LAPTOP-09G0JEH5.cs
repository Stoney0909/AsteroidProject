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
    public partial class Leaderboards : Form
    {
        public Leaderboards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //back to main menu
        {
            this.Hide();
            MainMenu Leaderboards = new MainMenu();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //opens instructions
        {

        }
    }
}