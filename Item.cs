using System;

namespace RPG
{
    class Item
    {
        string name;
        string description;
        string effect;
        string skin;

        public Item()
        {
            name = "potion";
            description = "healing pot";
            
        } 

        public virtual void Drop()
        {
            Console.WriteLine("Item was droped");
        }
        
    }
    class Weapon:Item
    {
        int Dmg;
        int Def;

        public override void Drop()
        {
            Console.WriteLine("The weapon was droped");
        }
    }
}