using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241217_hw1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();


            bool coin_front = true;
            //bool coin_back = false;

            bool result = CoinFlipAndResult(coin_front);

            if (result == true)
            {
                textBox1.Text = "승리";
            }
            else
            {
                textBox1.Text = "실패";
            }
        }

        bool CoinFlipAndResult(bool coinSide)
        {
            // 코인 뽑기
            Random randomObj = new Random();
            int randomValue = randomObj.Next();

            bool result = false;
            if (randomValue % 2 == 1)
            {
                result = true;
            }

            // 사용자 입력과 비교
            if (coinSide == result)
            {
                return true;
            }

            return false;
        }
    }
}