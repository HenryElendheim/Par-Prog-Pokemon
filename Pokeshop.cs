using System;
using System.Collections.Generic;
using System.Text;

namespace Par_Prog_Pokemon
{
    internal class Pokeshop
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }

        public Pokeshop(string name = "", int price = 0, int amount = 0)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public List<Pokeshop> shop = new List<Pokeshop>();

        public void AddShopItem()
        {
            shop.Add(new Pokeshop("Pokeball", 100, 3));
            shop.Add(new Pokeshop("Healing Potion", 300, 5));
        }

        public void ShowShop()
        {
            foreach (Pokeshop item in shop)
            {
                Console.WriteLine($"Name: {item.Name}\n" +
                                  $"Price: {item.Price}\n" +
                                  $"Amount: {item.Amount}\n");
            }
        }
    }
}
