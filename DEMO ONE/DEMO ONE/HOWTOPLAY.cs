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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //main menu
        {
            this.Hide();
            MainMenu Form1 = new MainMenu();
            Form1.CloneMenu();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) //top ten
        {
            this.Hide();
            Leaderboards Form1 = new Leaderboards();
            Form1.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
