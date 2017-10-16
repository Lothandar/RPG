using System;
using System.Collections.Generic;

namespace RPG
{
    class Player : Entity
    {
        PlayerClass Class= null;
        int gold = 0;
        Inventory inventory= new Inventory();
        public Player()
        {
            this.name = "Guillaume";
        }
    }
}
