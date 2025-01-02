using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20241217_hw1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string InputText = textBox_input.Text;

            bool FrontOrBack = false; // bool값 초기화

            // 문자열에 true or false가 있는지
            if (textBox_input.Text.Length > 0)
            {
                // textBox_input 문자열 확인
                if ((textBox_input.Text != "true") && (textBox_input.Text != "false")) // true or false가 아닐 때
                {
                    textBox_result.Text = " Error : true나 false를 입력하라.";
                    return; // 프로그램을 끝내기 위해 (return을 쓰면 탈출)
                }
                else // true나 false가 있을 때
                {
                    FrontOrBack = bool.Parse(InputText); // 입력값에 따라 true false 결정                   
                }

            }

            // 문자열이 없을 때
            else if (radioButton1.Checked) // 라디오버튼이 true
            {
                FrontOrBack = true; // 
            }

            else if (radioButton2.Checked) // 라디오버튼이 false
            {
                FrontOrBack = false;
            }

            textBox_result.Text = "입력하신값은" + FrontOrBack.ToString() + "입니다.\r\n";
            textBox_result.Text += "동전던지기 결과는?!\r\n";

            if (CoinFlipAndResult(FrontOrBack))
            {
                textBox_result.Text += "승리\r\n";
            }
            else 
            {
                textBox_result.Text += "패배\r\n";
            }



        }
        bool CoinFlipAndResult(bool coinSide)
        {
            // 코인 뽑기
            Random randomObj = new Random();
            int randomValue = randomObj.Next();

            if ((randomValue % 2 == 0) && coinSide) // 버튼 혹은 문자열이 true일 true
            {
                return true;
            }

            else if ((randomValue % 2 == 1) && coinSide)
            {
                return false;
            }
            return false; // 함수가 안될 때 탈출
        }
    }
}
