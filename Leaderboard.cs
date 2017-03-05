using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MemoryDen
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {

        }


        public void EmptyLeaderBoard()//H synarthsh auth kaleitai kathe fora prin ananeothei to to leaderboard wste na einai katharo gia tis nees eisodous
        {
            textBox1.Text = "";
        }
        public void WritePlace(string x)
        {
            textBox1.Text = textBox1.Text + x;//Auth h synarthsh grafei mia grammh sto Leaderboard h opoia dinetai apo th synarthsh Getplace ths classhs LeaderBoard
        }

        
        private void Leaderboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Leaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
