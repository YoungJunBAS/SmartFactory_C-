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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();


            int[] RefernceArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                RefernceArray[i] = i;
            }

            CheckingReference(ref RefernceArray);

            for (int i = 0; i < RefernceArray.Length; i++)
            {
                textBox.Text += RefernceArray[i].ToString();
            }

            textBox.Text += "\r\n";

            int OutArrayLength = 10;
            int[] OutArray;

            CheckingOut(out OutArray, OutArrayLength);

            for (int i = 0; i < OutArray.Length; i++)
            {
                textBox.Text += OutArray[i].ToString();
            }

        }

        public void CheckingReference(ref int[] RefArrary)
        {
            for (int i = 0; i < 10; i++)
            {
                RefArrary[i] = i;
            }
        }

        public void CheckingOut(out int[] OutArray, int ArrayLength)
        {
            OutArray = new int[ArrayLength];
            for (int i = 0; i < ArrayLength; i++)
            {
                OutArray[i] = i;
            }
        }
    }
}
