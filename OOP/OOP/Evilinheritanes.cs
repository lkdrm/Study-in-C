using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    ///public class Rect
    ///{
    ///    public int Width { get; set; }
    ///    public int Height { get; set; }
    ///}
    /// 
    ///public class Square : Rect
    ///{
    ///    
    ///}
    ///
    ///public static class AreaCalculator
    ///{
    ///    public static int CalcSquare (Square square)
    ///    {
    ///        return square.Height * square.Height;
    ///    }
    ///    
    ///    public static int CalcSquare (Rect rect)
    ///    {
    ///        return rect.Width * rect.Height;
    ///    }
    ///}
    /// </summary>
    public interface IShape
    {
        int CalcSquare();
    }

    public class Rect : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcSquare()
        {
            return Width * Height;
        }
    }
    public class Square : IShape
    {
        public int Sidelentgh { get; set; }
        public int CalcSquare()
        {
            return Sidelentgh * Sidelentgh;
        }
    }

}
