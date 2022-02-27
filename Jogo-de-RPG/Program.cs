using Jogo_de_RPG.src.Entities;
using System;

namespace Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Arus", 23, "Knight");
            Hero wizard = new Hero("Jennica", 23, "White Wizard");

            Console.Write(wizard.Attack());

        }
    }
}
