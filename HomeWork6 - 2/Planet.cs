using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_OTUS_2
{
    internal class Planet
    {
        public string Name { get;}

        public int Position { get; }

        public int LengthOfEcvator { get; }

        public Planet? PreviousPlanet { get; }

        public Planet(string name, int position, int length, Planet planet)
        {
            Name = name;
            Position = position;
            LengthOfEcvator = length;
            PreviousPlanet = planet;
        }
    
    }
}
