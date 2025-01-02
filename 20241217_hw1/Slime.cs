using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _20241231hw1
{
    internal class Slime : Monster
    {
        public Slime(string name) : base(name) { }

        public void CanclingTheAttack(string CharacterHaveWeapon)
        {
            if (CharacterHaveWeapon != "") 
            {
                Power = Damaged(0);
            }
        }
    }
}
