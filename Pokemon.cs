using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class Pokemon
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }

        public Pokemon(string name = "Test", int level = 0, string type = "No")
        {
            Name = name;
            Level = level;
            Type = type;
        }

        public void AddPokemonHardcoded()
        {
            pokemons.Add(new Pokemon("Pikachu", 5, "Electric"));
            pokemons.Add(new Pokemon("Charmander", 5, "Fire"));
            pokemons.Add(new Pokemon("Squirtle", 5, "Water"));
            pokemons.Add(new Pokemon("Bulbasaur", 5, "Grass"));
        }

        public void ShowPokemon()
        {
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine("Name: " + pokemon.Name + "\n" + "Level: " + pokemon.Level + "\n" + "Type: " + pokemon.Type + "\n\n");
            }
        }

        public Pokemon SearchPoke()
        {
            Console.WriteLine("Which pokemon do you want?\n");
            Console.Write("> ");
            string input = Console.ReadLine();

            for (int i = 0; i < pokemons.Count; i++)
            {
                if (pokemons[i].Name.ToLower() == input.ToLower())
                {
                    return pokemons[i];
                }
            }

            Console.WriteLine($"\nNo pokemon with the name '{input}' was found");
            return null;
        }

        public void PickPoke(Trainer trainer = null)
        {
            Pokemon found = SearchPoke();

            if (found == null)
            {
                return;
            }

            Console.WriteLine($"Are you sure you want to choose {found.Name} as your starter pokemon? (Y/N)");
            Console.Write("> ");
            string input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                Console.WriteLine("You chose " + found.Name);
                trainer.AddPokemon(found);
            }
            else
            {
                Console.WriteLine("Cancelled");
            }
    }
}
}
