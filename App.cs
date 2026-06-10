using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class App
    {
        public void Run()
        {
            bool running = true;
            var pokkermon = new Pokemon();
            var trener = new Trainer();

            trener.SetName();

            while (running)
            {
                Console.WriteLine($"1 - Pick pokemon\n" +
                    $"2 - Terrain\n" +
                    $"3 - Catch/Fight pokemon\n" +
                    $"4 - View Inventory\n" +
                    $"5 - Shop\n" +
                    $"0 - Exit\n");
                Console.Write("> ");
                string reply = Console.ReadLine();

                switch (reply)
                {
                    case "1":
                        pokkermon.AddPokemonHardcoded();
                        pokkermon.ShowPokemon();
                        pokkermon.PickPoke();

                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "0":
                        return;
                    default: break;
                }
            }
        }
    }
}
