using Jogo_de_RPG.src.Entities;
using System;

namespace Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));

            /* H.E.P.A
             * Herança
             * Encapsulamento
             * Polimorfismo
             * Abstração
             */
        }
    }
}
