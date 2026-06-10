using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class Pokemon
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        List<Pokemon> starterPokemons = new List<Pokemon>();

        public string Name { get; set; }
        public int Level { get; set; }
        public string Type { get; set; }

        public Pokemon(string name = "Test", int level = 0, string type = "No")
        {
            Name = name;
            Level = level;
            Type = type;
        }

        public List<Pokemon> GetPokemons()
        {
            return pokemons;
        }

        public List<Pokemon> GetStarterPokemons()
        {
            return starterPokemons;
        }

        public void AddPokemonHardcoded()
        {
            pokemons.Add(new Pokemon("Blastoise", 5, "Water"));
            pokemons.Add(new Pokemon("Tommelgeir", 5, "Ground"));
            pokemons.Add(new Pokemon("Geodude", 5, "Ground"));
        }

       public void StarterPokemon()
        {
            starterPokemons.Add(new Pokemon("Pikachu", 5, "Electric"));
            starterPokemons.Add(new Pokemon("Charmander", 5, "Fire"));
            starterPokemons.Add(new Pokemon("Squirtle", 5, "Water"));
            starterPokemons.Add(new Pokemon("Bulbasaur", 5, "Grass"));
        }

        public void ShowPokemon()
        {
            foreach (var pokemon in pokemons)
            {
                Console.WriteLine("Name: " + pokemon.Name + "\n" + "Level: " + pokemon.Level + "\n" + "Type: " + pokemon.Type + "\n\n");
            }
        }

        public void ShowStarter()
        {
            foreach (var pokemon in starterPokemons)
            {
                Console.WriteLine("Name: " + pokemon.Name + "\n" + "Level: " + pokemon.Level + "\n" + "Type: " + pokemon.Type + "\n\n");
            }
        }

        public Pokemon SearchStarter()
        {
            Console.WriteLine("Which pokemon do you want?\n");
            Console.Write("> ");
            string input = Console.ReadLine();

            for (int i = 0; i < starterPokemons.Count; i++)
            {
                if (starterPokemons[i].Name.ToLower() == input.ToLower())
                {
                    return starterPokemons[i];
                }
            }

            Console.WriteLine($"\nNo pokemon with the name '{input}' was found");
            return null;
        }

        public void PickPoke(Trainer trainer = null)
        {
            Pokemon found = SearchStarter();

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
