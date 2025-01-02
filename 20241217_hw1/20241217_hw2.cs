using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Web;

namespace _20241217_hw1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string Confucius = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";

            string pro1 = Confucius.Remove(Confucius.IndexOf("-"));


            string[] FindingWords = {"얼마나", "천천히", "가는지"};

            string[] pro2 = new string[3];

            for (int i = 0; i < FindingWords.Length; i++)
            {
                int temp = Confucius.IndexOf(FindingWords[i]);

                pro2[i] = Confucius.Substring(temp, FindingWords[i].Length);

            }

            string pro3 = Confucius.Replace(".", "").Replace("-", "").Replace(" ", ",").ToString();

            textBox1.Text += pro1 + "\r\n";
            textBox1.Text += pro2[0] + "\r\n";
            textBox1.Text += pro2[1] + "\r\n";
            textBox1.Text += pro2[2] +"\r\n";
            textBox1.Text += pro3;








        }
    }
}
