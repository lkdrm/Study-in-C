using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{   // public
    // internal
    // protected
    // private

    public class Pointed
    {
        private int x;
        private int y;
        public Pointed(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Character
    {
        public int Health { get; private set; } = 100;

        // now it can`t change.
        public const int Speed = 5;
        // or with readonly
        /// <summary>
        ///  private readonly int Speed = 5;
        ///  
        /// this.Speed = 5;
        /// </summary>
        public string Race { get; private set; }

        //public int Armor {get; private set; }

        public Character(string race, int armor = 25)
        {
            Race = race;
            // or
            // Armor = 25;
        }

        // or

        //private int health = 100;

        //public int Health
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //       health = value;
        //    }
        //}

        // or

        //public int GetHealth()
        //{
        //    return health;
        //}

        //private void SetHealth(int value)
        //{
        //   health = value;
        //}

        public void hit(int damage)
        {
            if(damage > Health)
            {
                damage = Health;
            }
            Health -= damage;
        }

        public int PrintSpeed()
        {
            return Speed;
        }

        public void IncreaseSpeed()
        {
            //Speed += 2;
        }
      
    }
}
