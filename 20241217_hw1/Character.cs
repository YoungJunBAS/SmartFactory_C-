using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20241231hw1
{
    public class Character
    {
        public int HP { get; set;}
        public int MP { get; set; }        
        public int Power { get; set; }
        static Item item;
        private int CharacterCode { get; } = 112;
        private string name;
        private string Weapon;
        private string Armor;
        private bool Skill;



        public Character(string name) // 객체 생성 시 생성자 만들기(외부에서 받는 값)
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
            HP = 200;
            MP = 100;
            Skill = false;
            Power = 10;

            SelectingItem(); // 아이템 장착

            Weapon = item.Weapon;
            Armor = item.Armor;
            HP += item.HP;
            Power += item.Power;
        }

        public void SelectingItem()
        {
            Random RandomNum = new Random();
            int ItemToken = RandomNum.Next(1, 4);
            if (ItemToken == 1)
            {
                item.Weapon = "묘목 나뭇가지";
                item.Armor = "1000년된 도깨비 팬티";
                item.Power = 1;
                item.HP = 1;
            }

            else if (ItemToken == 2)
            {
                item.Weapon = "지옥 수문장의 채찍";
                item.Armor = "이카루스가 만든 날개";
                item.Power = 5;
                item.HP = 5;
            }

            else if (ItemToken == 3)
            {
                item.Weapon = "타락한 대천사의 성검";
                item.Armor = "성녀 베로니카의 솔브";
                item.Power = 10;
                item.HP = 10;
            }
        }

        public int Attack(int TargetCharacterCode)
        {
            if (TargetCharacterCode == 211)
            {
                return Power;
            }
            else 
            {
                return 0;
            }
        }

        public int Damaged(int Power)
        {
            HP -= Power;
            return HP;
        }
    }
}
