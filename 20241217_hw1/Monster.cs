using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241231hw1
{
    public class Monster
    {
        public int HP { get; set; }
        public int MP { get; set; }
        public int Power { get; set; }
        static Item item;
        private int CharacterCode { get; } = 211;
        private string name;
        private string Weapon;
        private string Armor;
        private bool Skill;



        public Monster(string name) // 객체 생성 시 생성자 만들기(외부에서 받는 값)
        {
            SetAbility(name);
        }

        struct Item // 캐릭터들이 장착하는 아이템
        {
            public string Weapon;
            public string Armor;
            public int Power;
            public int HP;
        }

        public void SetAbility(string name)
        {
            this.name = name;
            HP = 100;
            MP = 50;
            Skill = false;
            Power = 5;
        }
        public int getHP() // Test 목적
        {
            return HP;
        }

        public int Attack(int TargetCharacterCode)
        {
            if (TargetCharacterCode == 112)
            {
                return Power;
            }
            else
            {
                return 0;
            }
        }

        public int Damaged(int EnermyPower)
        {
            HP -= EnermyPower;
            return HP;
        }
    }
}
