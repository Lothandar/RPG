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

        public string ItemName { get; set; }

        public virtual void Drop()
        {
            //TODO: Implement the drop method
            Console.WriteLine("Item was droped");
        }
        
    }
    class Weapon:Item
    {
        int Dmg;
        int Def;



        public override void Drop()
        {
            //TODO: Implement the drop method
            Console.WriteLine("The weapon was droped");

        }
    }
}