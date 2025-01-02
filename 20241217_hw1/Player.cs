using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _20241231hw1
{
    internal class Player : Character
    {        
        public Player(string name) : base(name) { }

        public void GettingAnQuestFromNPC()
        { 
            // 매소드 작성
        }

        public void Slash(int MP, int Power) 
        {
            if (MP > 0)
            {
                MP -= 8;
                //Power = 2 * Attack(true);
            }
            else 
            {
                //Power = Attack(true);
            }
        }
    }
}
