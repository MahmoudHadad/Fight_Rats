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
    public partial class Game_Window : Form
    {
        private String playerName;
        public Game_Window(String playerName)
        {
            this.playerName = playerName;
            InitializeComponent();
            //
            // labels
            //
            labels = new System.Windows.Forms.Label[numberOfLabels];

            for (int i = 0; i < numberOfLabels; i++)
            {
                labels[i] = new System.Windows.Forms.Label();
                this.Controls.Add(this.labels[i]);
            }




            int xLocation = 13;
            int yLocation = 13;

            int initialxLocation = 25;

            int xSize = 100;
            int ySize = 74;

            for (int i = 0; i < labelsInRow; i++)
            {
                xLocation = initialxLocation;
                for (int j = 0; j < labelsInColumn; j++)
                {
                    int indx = (i * labelsInColumn) + j;
                    this.labels[indx].Location = new System.Drawing.Point(xLocation, yLocation);
                    this.labels[indx].Size = new System.Drawing.Size(xSize, ySize);
                    this.labels[indx].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.labels[indx].TabIndex = 0;
                    this.labels[indx].Text = "" + indx;

                    xLocation += xSize + 20;

                }
                yLocation += ySize + 20;
            }
        }

       

        private void Game_Window_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
