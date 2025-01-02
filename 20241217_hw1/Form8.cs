using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241217_hw1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            textBox_score_me.Text = UserScore.ToString();
            textBox_score_cpu.Text = pcScore.ToString();
        }

        enum Handsign
        {
            Rock,
            Scissors,
            Paper
        }
        
        Random rand = new Random();

        int UserScore = 0;
        int pcScore = 0;

        private void radioButton_scissors_Click(object sender, EventArgs e)
        {
            Handsign Mychoice = Handsign.Scissors;
            Handsign pcPick = ComputerChoice();
            GameStart(Mychoice, pcPick);
        }

        private void radioButton_rock_Click(object sender, EventArgs e)
        {
            Handsign Mychoice = Handsign.Rock;
            Handsign pcPick = ComputerChoice();
            GameStart(Mychoice, pcPick);

        }

        private void radioButton_paper_Click(object sender, EventArgs e)
        {
            Handsign Mychoice = Handsign.Paper;
            Handsign pcPick = ComputerChoice();
            GameStart(Mychoice, pcPick);

        }

        Handsign ComputerChoice()
        {
            return (Handsign)rand.Next(0, 3);

        }
        bool UserWinTheGame(Handsign MyPick, Handsign pcPick)
        {
            switch (MyPick) // User : 가위, PC :보
            {
                case Handsign.Scissors:
                    return pcPick == Handsign.Paper;

                case Handsign.Rock:
                    return pcPick == Handsign.Scissors;

                case Handsign.Paper:
                    return pcPick == Handsign.Rock;

                default:
                    return false;                    
            }
        }

        bool isDraw(Handsign MyPick, Handsign pcPick)
        {
            if (MyPick == pcPick) 
            {
                return true;
            }
            return false;
        }

        void GameStart(Handsign MyPick, Handsign pcPick)
        {

            if (isDraw(MyPick, pcPick))
            {
                textBox_result.Text = "무승부!!";
                return;
            }

            if (UserWinTheGame(MyPick, pcPick))
            {
                UserScore += 1;
                textBox_result.Text = "\"나\"가 점수 " + UserScore + "점 획득!!";
                textBox_cpu_result.Text = pcPick.ToString();
                textBox_score_me.Text = UserScore.ToString();
                textBox_score_cpu.Text = pcScore.ToString();
                if (UserScore == 3)
                {
                    textBox_result.Text = "\"나\"가 승리!!";
                    ResetTheGame();
                    return;
                }
                else if (pcScore == 3)
                {
                    textBox_result.Text = "컴퓨터가 승리!!";
                    ResetTheGame();
                    return;
                }

                return;
            }
            else
            {
                pcScore += 1;
                textBox_result.Text = "컴퓨터가 점수 " + pcScore + "점 획득!!";
                textBox_cpu_result.Text = pcPick.ToString();
                textBox_score_me.Text = UserScore.ToString();
                textBox_score_cpu.Text = pcScore.ToString();
                if (UserScore == 3)
                {
                    textBox_result.Text = "\"나\"가 승리!!";
                    ResetTheGame();
                    return;
                }
                else if (pcScore == 3)
                {
                    textBox_result.Text = "컴퓨터가 승리!!";
                    ResetTheGame();
                    return;
                }
                return;
            }
        }
        void ResetTheGame() 
        {
            UserScore = 0;
            pcScore = 0;
        }
    }
}
