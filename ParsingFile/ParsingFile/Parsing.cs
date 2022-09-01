using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingFile
{
    public class Parsing
    {
        public string Country { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int Rating { get; set; }

        public int Categori { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"Full name : {FirstName} + ' '+ {LastName}. Rating is : {Rating},{Categori} and from : {Country}. Born {BirthYear}";
        }

        public static Parsing ParseFide(string line)
        {
            string[] parts = line.Split(";");
            return new Parsing()
            {
                Id = int.Parse(parts[0]),
                LastName = parts[1].Split(",")[0],
                FirstName = parts[1].Split(",")[1],
                Categori = int.Parse(parts[2]),
                Country = parts[2],
                Rating = int.Parse(parts[3]),
                BirthYear = int.Parse(parts[4]),
            };
        }

    }
}
