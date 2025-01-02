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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        public class VendingMachine
        {
            struct VendingMachineField
            {
                public int LeftMoney { get; private set; }
                public int LeftBeverage { get; private set; }
                public int CheckingToken { get; private set; }
            }

            VendingMachine LeftMoney_100;

            void CheckingLeftMoney(VendingMachineField LeftMoney)
            {
                LeftMoney_100 = new VendingMachine();
                VendingMachine LeftMoney_500 = new VendingMachine();
                VendingMachine LeftMoney_1000 = new VendingMachine();
                VendingMachine CheckingToken = new VendingMachine();


                if (LeftMoney_100 == CheckingToken) 
                {
                    //textBox_MoneySlot.Text = "100원 동전이 부족합니다.";
                }
            }

        }

        public class VendingMachineManager
        {
            
        }

        public class VendingMachineCustomer
        {
            
        }

        private void button_MoneySlot_Click(object sender, EventArgs e)
        {

        }

        private void button_Beverage_Click(object sender, EventArgs e)
        {

        }
    }
}
