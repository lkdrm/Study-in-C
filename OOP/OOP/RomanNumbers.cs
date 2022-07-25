using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class ArabicNumbers
    {
        string result = "";
        private static Dictionary<string, int> baseList = new Dictionary<string, int>()
        {
            {"I",1 },
            {"II", 2 },
            {"III", 3 },
            {"IV", 4 },
            {"V", 5},
            {"VI", 6},
            {"VII", 7},
            {"VIII", 8},
            {"IX", 9},
            {"X", 10},
        };
        public string RomanNumbers(string number)
        {
            result += baseList[number];
            return result;
        }
    }
}
