using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace _20241217_hw1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            int ANumberOfStudents = 5;
            int[] RandomScoreArray = new int[ANumberOfStudents];
            Random random = new Random();

            for (int i = 0; i <ANumberOfStudents; i++)
            {
                // 중복 확인 루프
                bool isDuplicate;
                do
                {
                    isDuplicate = false;
                    RandomScoreArray[i] = random.Next(0, 100 + 1); // 난수 생성

                    // 배열에서 중복되는 값이 있는지 확인
                    for (int j = 0; j < i; j++)
                    {
                        if (RandomScoreArray[i] == RandomScoreArray[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                } 
                while (isDuplicate);

                textBox_result.Text += "학생" + (i+1) + "의 점수 : " + RandomScoreArray[i] + "점" + "\r\n";
            }
        }
    }
}
