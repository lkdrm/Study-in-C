using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    // value - value;
    // reference types - it`s like class.

    public struct PointVal
    {
        public int X;
        public int Y;

        public void LogValue ()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }

    public class PointRef
    {
        public int X;
        public int Y;
        
        public void LogValue ()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }
    }
}
