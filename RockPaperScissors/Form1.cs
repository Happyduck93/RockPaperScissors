//Welcome to Rock Paper Scissors Game! 
//Author : D.Kim
//Date : May 2020
//This program let the user to do the Rock Paper scissors game versus computer. 
//How to use: 
//1.press start button
//2.choose one of the 'Rock', 'Paper', or 'Scissors' button of your choice
//3.Result will be displayed
//4.Repeat the process if you want more plays!
//5.To exit press X on top right corner. 
// Stop button : to stop the timer(indicates how many times the computer changed its entry)




using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        //variables for timer (how many times the computer changed its entry) 
        private int i ;
        private int j ;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            i = 0;
            j = 0;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            
            var random = new Random();
            //1, 4(index -> case 1,2,3) or random.Next(3)  -> case 0,1,2
            switch (random.Next(3))
            {
                case 0:
                    lblComputer.Text = "Rock";
                    picComputer.Image = Properties.Resources.Rock;
                    break;
                case 1:
                    lblComputer.Text = "Paper";
                    picComputer.Image = Properties.Resources.Paper;
                    break;
                case 2:
                    lblComputer.Text = "Scissors";
                    picComputer.Image = Properties.Resources.Scissors;
                    break;
                default:
                    break;

            }


            //0# - format
            lblCentSecont.Text = i.ToString("0#");
            lblSecond.Text = j.ToString("0#");
            i++;
            if (i == 60)
            {
                i = 0;
                j++;
            }
            if (j == 10)
            {
                timer.Stop();
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }



        private void btnRock_Click(object sender, EventArgs e)
        {


            //stop timer
            timer.Stop();
            lblPlayer.Text = "Rock";
            picPlayer.Image = Properties.Resources.Rock;
            switch (lblComputer.Text)
            {
                case "Rock":
                    lblResult.Text = "Play again!";
                    break;
                case "Paper":
                    lblResult.Text = "Computer Won!";
                    break;
                case "Scissors":
                    lblResult.Text = "Player Won!";
                    break;
                default:
                    break;

            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            //stop timer
            timer.Stop();
            lblPlayer.Text = "Paper";
            picPlayer.Image = Properties.Resources.Paper;
            switch (lblComputer.Text)
            {
                case "Rock":
                    lblResult.Text = "Player Won!";
                    break;
                case "Paper":
                    lblResult.Text = "Play again!";
                    break;
                case "Scissors":
                    lblResult.Text = "Computer Won!";
                    break;
                default:
                    break;

            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            //stop timer
            timer.Stop();
            lblPlayer.Text = "Scissors";
            picPlayer.Image = Properties.Resources.Scissors;
            switch (lblComputer.Text)
            {
                case "Rock":
                    lblResult.Text = "Computer Won!";
                    break;
                case "Paper":
                    lblResult.Text = "Player Won!";
                    break;
                case "Scissors":
                    lblResult.Text = "Play again!";
                    break;
                default:
                    break;

            }
        }


    }
}
