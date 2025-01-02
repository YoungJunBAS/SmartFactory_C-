using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20241231hw1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _20241217_hw1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button_checking_Click(object sender, EventArgs e)
        {
            //Character player1 = new Character("Player1");
            //Character NPC1 = new Character("NPC1");
            //Monster Orc1 = new Monster("Orc1");
            //Monster Slime1 = new Monster("Slime1");
        }

        private void button_battle_Click(object sender, EventArgs e)
        {
            Character player1 = new Character("Player1"); // CharacterToken 1
            Character NPC1 = new Character("NPC1"); // CharacterToken 2
            Monster Orc1 = new Monster("Orc1"); // CharacterToken 3
            Monster Slime1 = new Monster("Slime1"); // CharacterToken 4
            textBox.Text = "캐릭터 생성!!";

            // 랜덤으로 상대 정하기
            Random RandomNum = new Random();
            int EnermyToken = RandomNum.Next(1, 4);

            int TurnCount = 0;

            if (EnermyToken == 3) 
            {
                while (player1.HP < 0 || Orc1.HP < 0)
                {
                    textBox.Text = "";
                }
            }
        }

        public void Winner(int PlayerHP, int EnermyHP)
        {
            if (PlayerHP <= 0 && EnermyHP > 0)
            {
                
            }
        }
    }
}
