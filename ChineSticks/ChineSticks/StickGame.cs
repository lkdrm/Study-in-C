using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ChineSticks
{
    public class StickGame
    {   
        // can change a stick . Default is 10;
        public int sticks { get; private set; } = 10;
        
        public void choice(int choice)
        {
            if(choice >0 && choice <=3)
            {
                sticks-=choice;
               
            }
            else if(choice > 3)
            {
                throw new ArgumentException("Only from 1 to 3.");
            }
        }
    
    
    }

}