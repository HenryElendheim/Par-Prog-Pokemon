using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class Trainer
    {
        public string Name { get; set; }

        public List<Pokemon> pokemen = new List<Pokemon>();

        public Inventory inv { get; set; } = new Inventory();


        public string[] invArray;

        public void OpenInv()
        {
            
        }

        public void ShowPokemon()
        {
            if(pokemen.Count == 0)
            {
                Console.WriteLine("No pokemon's here");
                return;
            }

            foreach (var poke in pokemen)
            {
                Console.WriteLine($"Pokemon: {poke.Name} | {poke.Level} | {poke.Type}");
            }
        }

        public Trainer(string name = null)
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
