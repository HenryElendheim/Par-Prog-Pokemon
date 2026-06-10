using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class Trainer
    {
        public string Name { get; set; }

        public List<Pokemon> pokemen = new List<Pokemon>();

        public Trainer(string name = "")
        {
            Name = name;
            new Pokemon();
        }

        public void SetName()
        {
            Console.WriteLine("What is your name trainer?");
            Console.Write("> ");
            string input = Console.ReadLine();

            Name = input;

            Console.WriteLine("Nice to meet you " + Name + "\n");
        }

        public void AddPokemon(Pokemon pokemon)
        {
            pokemen.Add(pokemon);
        }
    }
}
