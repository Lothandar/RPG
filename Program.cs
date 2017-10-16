using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "Player 1";

            Weapon sword = new Weapon();
            sword.ItemName = "Holy Sword";

            Weapon sword1 = new Weapon();
            sword1.ItemName = "Rifle";

            Weapon sword2 = new Weapon();
            sword2.ItemName = "Katana";

            Inventory inventory = new Inventory();
            inventory.items.Add(sword);
            inventory.items.Add(sword1);
            inventory.items.Add(sword2);

            Console.WriteLine($"Player Name: {player.Name}");
            foreach (var weapon in inventory.items )
            {
                Console.WriteLine($"Weapon Name: {weapon.ItemName}");
            }

            sword1.Drop();
            
            Console.ReadKey(true);
        }
    }
}
