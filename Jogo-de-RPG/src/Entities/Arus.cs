using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_RPG.src.Entities
{
    class Arus
    {
        public Arus(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }

        public Arus()
        {

        }

        public string Name;
        public int level;
        public string HeroType;

    }
}
