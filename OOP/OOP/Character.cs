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
        public Race Race { get; private set; }

        public int Armor { get; private set; }
        public string Name { get; private set; }

        // now it can`t change.
        public const int Speed = 5;
        // or with readonly
        /// <summary>
        ///  private readonly int Speed = 5;
        ///  
        /// this.Speed = 5;
        /// </summary>

        //public int Armor {get; private set; }

        public Character(Race race, int armor = 25)
        {
            Race = race;
            // or
            // Armor = 25;
            //Armor = (int)race; or I can :
            switch (race)
            {
                case Race.Elven:
                    Armor = 25;
                    break;
                case Race.Human:
                    Armor = 15;
                    break;
                case Race.Orcs:
                    Armor = 40;
                    break;
                default:
                    throw new ArgumentException("Uknown race...");
        
            }
            //or

            if (race == Race.Human)
            {
                Armor = 15;
            }
            else if (race == Race.Elven)
            {
                Armor = 25;
            }
            else if (race == Race.Orcs)
            {
                Armor = 40;
            }
            else
            {
                throw new ArgumentException("Uknown race...");
            }
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
            if(Health == 0)
            {
                throw new InvalidOperationException("Can`t hit a dead pleayer.");
            }
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

        public Character(string name , int armor)
        {
            if (name==null)
            {
                throw new ArgumentNullException("Name arg can`t be null.");
            }
            if(armor <0 || armor > 100)
            {
                throw new ArgumentException("Armor can`t be less then 0 or greater than 100.")
            }
            Name = name;
            Armor = armor;
        }
      
    }
}
