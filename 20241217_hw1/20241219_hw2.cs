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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string inputADayOfTheWeek = textBox_input.Text;

            DayOfTheWeek dotw = InputCheck(inputADayOfTheWeek);

            switch (dotw) 
            {
                case DayOfTheWeek.Monday:
                    textBox_result.Text = "월요일은 원(월)래 술마시는 날";
                    break;

                case DayOfTheWeek.Tuesday:
                    textBox_result.Text = "화요일은 화가 나나서 마시는 날";
                    break;

                case DayOfTheWeek.Wednesday:
                    textBox_result.Text = "수요일은 수수하게 마시는 날";
                    break;

                case DayOfTheWeek.Thursday:
                    textBox_result.Text = "목요일은 목빠지게 마시는 날";
                    break;

                case DayOfTheWeek.Friday:
                    textBox_result.Text = "금요일은 금방 만나 술마시는 날";
                    break;

                case DayOfTheWeek.Saturday:
                    textBox_result.Text = "토요일은 토나게 마시는 날";
                    break;

                case DayOfTheWeek.Sunday:
                    textBox_result.Text = "일요일은 일 안해서 마시는 날";
                    break;

                default:
                    textBox_result.Text = "요일을 영어로 입력해라";
                    break;
            }

        }
        enum DayOfTheWeek
        { 
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Error = 999
        }

        DayOfTheWeek InputCheck(string message) 
        {
            string textBox_input = message;

            switch (message)
            {
                case "Monday":
                    return DayOfTheWeek.Monday;
                    break;

                case "Tuesday":
                    return DayOfTheWeek.Tuesday;
                    break;

                case "Wednesday":
                    return DayOfTheWeek.Wednesday;
                    break;

                case "Thursday":
                    return DayOfTheWeek.Thursday;
                    break;

                case "Friday":
                    return DayOfTheWeek.Friday;
                    break;

                case "Saturday":
                    return DayOfTheWeek.Saturday;
                    break;

                case "Sunday":
                    return DayOfTheWeek.Sunday;
                    break;

                default:
                    return DayOfTheWeek.Error;
                    break;

            }
        }

    }
}
