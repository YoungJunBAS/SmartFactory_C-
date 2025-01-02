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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            int a = 8;
            int b = 7;

            int [] result = Caculation_Devide_QuotientAndRemainder(a, b);

            for (int i = 0; i < result.Length; i++)
            {
                textBox1.Text += result[i] + "\r\n";
            }
            //textBox1.Text += result[0] + "\r\n";
            //textBox1.Text += result[1];
        }

        int[] Caculation_Devide_QuotientAndRemainder(int a, int b)
        {

            int[] ResultArray = new int[2];

            ResultArray[0] = a / b;
            ResultArray[1] = a % b;

            return ResultArray;

        }
       
    }
}
