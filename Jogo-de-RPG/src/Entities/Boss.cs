﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_RPG.src.Entities
{
    public interface Boss
    {
        public int Name { get; set; }
        public string hadouken();
    }
}
