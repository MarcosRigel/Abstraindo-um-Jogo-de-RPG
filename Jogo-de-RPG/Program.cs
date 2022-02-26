using Jogo_de_RPG.src.Entities;
using System;

namespace Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus();
            hero.Name = "Arus";
            hero.level = 2;
            hero.HeroType = "Knight";

            Console.Write("");
        }
    }
}
