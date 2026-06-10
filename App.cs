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
            var inv = new Inventory();
            var terrain = new Terrain();
            var shop = new Pokeshop();


            trener.SetName();
            pokkermon.AddPokemonHardcoded();
            pokkermon.StarterPokemon();
            shop.AddShopItem();
            terrain.SetPokemons(pokkermon.GetPokemons());

            while (running)
            {
                Console.WriteLine($"1 - Pick pokemon\n" +
                                  $"2 - Explore\n" +
                                  $"3 - View Pokemon\n" +
                                  $"4 - Shop\n" +
                                  $"0 - Exit\n");
                Console.Write("> ");
                string reply = Console.ReadLine();

                switch (reply)
                {
                    case "1":
                        pokkermon.ShowStarter();
                        pokkermon.PickPoke(trener);

                        break;
                    case "2":
                        terrain.SetTrainer(trener);
                        terrain.Area();
                        break;
                    case "3":
                        trener.ShowPokemon();
                        break;
                    case "4":
                        shop.ShowShop();
                        break;
                    case "0":
                        return;
                    default: break;
                }
            }
        }
    }
}
