using Jogo_de_RPG.src.Entities;
using System;

namespace Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.Write(wizard.Attack(1));
        }
    }
}
