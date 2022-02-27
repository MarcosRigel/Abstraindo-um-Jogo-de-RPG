using Jogo_de_RPG.src.Entities;
using System;

namespace Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Arus hero = new Arus("Arus", 23, "Knight");
            Arus wizard = new Arus("Jennica", 23, "White Wizard");

            Console.Write(wizard.Attack());

        }
    }
}
