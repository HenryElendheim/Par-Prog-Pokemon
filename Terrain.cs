using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class Terrain
    {
        List<Pokemon> Pokemons = new List<Pokemon>();

        public void SetPokemons(List<Pokemon> pokemons)
        {
            Pokemons = pokemons;
        }

        Trainer Trainer;

        public void SetTrainer(Trainer trainer)
        {
            Trainer = trainer;
        }

        public int RNG(int pokeCount)
        {
            Random rand = new Random();
            return rand.Next(0, pokeCount);
        }

        public void WaterPark()
        {
            List<Pokemon> waterPokemons = new List<Pokemon>();

            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Type == "Water")
                {
                    waterPokemons.Add(pokemon);
                }
            }

            if (waterPokemons.Count == 0)
            {
                Console.WriteLine("No water pokemon found");
                return;
            }

            int index = RNG(waterPokemons.Count);
            Pokemon randomPokemon = waterPokemons[index];

            Console.WriteLine($"A wild {randomPokemon.Name} appeared");

            FightMode(randomPokemon);
        }

        public void FlameyRoad()
        {
            List<Pokemon> firePokemons = new List<Pokemon>();

            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Type == "Fire")
                {
                    firePokemons.Add(pokemon);
                }
            }

            if (firePokemons.Count == 0)
            {
                Console.WriteLine("No fire pokemon found");
                return;
            }

            int index = RNG(firePokemons.Count);
            Pokemon randomPokemon = firePokemons[index];

            Console.WriteLine($"A wild {randomPokemon.Name} appeared");

            FightMode(randomPokemon);
        }

        public void RockyRoad()
        {
            List<Pokemon> groundPokemons = new List<Pokemon>();

            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Type == "Ground")
                {
                    groundPokemons.Add(pokemon);
                }
            }

            if (groundPokemons.Count == 0)
            {
                Console.WriteLine("No ground pokemon found");
                return;
            }

            int index = RNG(groundPokemons.Count);
            Pokemon randomPokemon = groundPokemons[index];

            Console.WriteLine($"A wild {randomPokemon.Name} appeared");

            FightMode(randomPokemon);
        }

        public void GrassyPlain()
        {
            List<Pokemon> grassPokemons = new List<Pokemon>();

            foreach (Pokemon pokemon in Pokemons)
            {
                if (pokemon.Type == "Grass")
                {
                    grassPokemons.Add(pokemon);
                }
            }

            if (grassPokemons.Count == 0)
            {
                Console.WriteLine("No grass pokemon found");
                return;
            }

            int index = RNG(grassPokemons.Count);
            Pokemon randomPokemon = grassPokemons[index];

            Console.WriteLine($"A wild {randomPokemon.Name} appeared");

            FightMode(randomPokemon);
        }

        public void FightMode(Pokemon currentPokemon)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine($"1. Catch\n" +
                                  $"2. Attack\n" +
                                  $"3. Flee\n");
                Console.Write("> ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Catch(currentPokemon);
                        isRunning = false;
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                }
            }

        }

        public void Catch(Pokemon catchPokemon)
        {
            Console.WriteLine("You caught " + catchPokemon.Name + "!");
            Trainer.AddPokemon(catchPokemon);
        }

        public void Area()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine($"1. Water park\n" +
                                  $"2. Grassy plain\n" +
                                  $"3. Rocky Road\n" +
                                  $"4. Flamey Road\n");
                Console.Write("> ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        WaterPark();
                        break;
                    case "2":
                        GrassyPlain();
                        break;
                    case "3":
                        RockyRoad();
                        break;
                    case "4":
                        FlameyRoad();
                        break;
                    default:
                        isTrue = false;
                        break;
                }
            }
        }
    }
}
