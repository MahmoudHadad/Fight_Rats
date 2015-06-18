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
        private int currentLabel = 0;
        private int numberOfTrials = 10;
        private int score = 0;
        private bool isGoalClicked = false;
 
        public Game_Window(String playerName)
        {
            this.playerName = playerName;
            InitializeComponent();
            this.playerNameLabel.Text = playerName;
            setScore ( score);
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
            int yLocation = 83;
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
                    labels[indx].Click += new EventHandler(test);
                   // this.labels[indx].Text = "" + indx;

                    xLocation += xSize + 20;

                }
                yLocation += ySize + 20;
            }
        }
        
        /////////////////////////////
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        /////////////////////////////
        private void test(object sender, EventArgs e)
        {
            if(isGoalClicked)
                return;
            for (int i = 0; i < numberOfLabels;i++ )
                if (sender == labels[i] && currentLabel == i)
                {
                    isGoalClicked = true;
                    score++;
                    MessageBox.Show("clicked", "" + i);
                }
             
        }
        /////////////////////////////
        private void setScore(int score)
        {
            scoreLabel.Text = score + " / " + numberOfTrials;
        } 
    }
}
