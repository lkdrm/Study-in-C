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
    public class Character
    {
        public int health { get; private set; } = 100;
        
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
            if(damage > health)
            {
                damage = health;
            }
            health -= damage;
        }
    }
}
