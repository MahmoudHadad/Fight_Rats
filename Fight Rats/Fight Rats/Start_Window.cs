using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_Rats
{
    public partial class Start_Window : Form
    {
        public Start_Window()
        {
            InitializeComponent();
        }

        private void Start_Window_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Game_Window(playerName.Text).ShowDialog();
            this.Dispose();
        }
    }
}
