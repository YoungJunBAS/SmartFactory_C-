using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20241217_hw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            #region 24.12.17 실습1

            // Ctrl + K + C 전체주석
            // Ctrl + K + U 전체주석해제

            string pro1 = "동해 물과 백두산이";
            string pro2 = "토요일에 먹는 토마토";
            string pro3 = "질서 있는 퇴장";
            string pro4 = "그 사람의 그림자는 그랬다.";
            string pro5 = "삼성 갤럭시";
            string pro6 = "오늘은 왠지 더 배고프다";
            string pro7 = "이름, 나이, 전화번호";
            string pro8 = "우리 나라 만세";

            string[] ResultArray = new string[10];

            ResultArray[0] = pro1.IndexOf("백두산").ToString();
            ResultArray[1] = pro2.LastIndexOf("토").ToString();
            ResultArray[2] = pro3.Contains("퇴").ToString();
            ResultArray[3] = pro4.Replace("그", "이").ToString();
            ResultArray[4] = pro5.Insert(pro5.IndexOf("삼성")+2, "애플").ToString();
            ResultArray[5] = pro6.Remove(pro6.IndexOf("더"), 2).ToString();

            string[] temp = pro7.Split(',');

            ResultArray[6] = temp[0];
            ResultArray[7] = temp[1];
            ResultArray[8] = temp[2];

            ResultArray[9] = pro8.Substring(pro8.IndexOf("나라"), 2);

            for (int i = 0; i < ResultArray.Length; i++)
            {
                textBox1.Text += ResultArray[i] + "\r\n";
            }
            #endregion






        }
    }
}
