using System;

namespace HomeWork6_OTUS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planet1 = new
            {
                Name = "Венера",
                Position = 2,
                LengthOfEcvator = 12100,
                PreviousPlanet = (object)null
            };

            var planet2 = new
            {
                Name = "Земля",
                Position = 3,
                LengthOfEcvator = 40075,
                PreviousPlanet = (object)planet1
            };

            var planet3 = new
            {
                Name = "Марс",
                Position = 4,
                LengthOfEcvator = 21344,
                PreviousPlanet = (object)planet2
            };

            var planet4 = new
            {
                Name = "Венера",
                Position = 2,
                LengthOfEcvator = 12100,
                PreviousPlanet = (object)null
            };

            //Console.WriteLine(planet2);
            Console.Write("Имя:" + planet2.Name + ", порядковый номер:" + planet2.Position + ", длина экватора:" + planet2.LengthOfEcvator);
            Console.WriteLine($". Эквивалентность планете Венера: {planet2.Equals(planet1)}");

            //Console.WriteLine(planet3);
            Console.Write("Имя:" + planet3.Name + ", порядковый номер:" + planet3.Position + ", длина экватора:" + planet3.LengthOfEcvator);
            Console.WriteLine($". Эквивалентность планете Венера: {planet3.Equals(planet1)}");

            //Console.WriteLine(planet4);
            Console.Write("Имя:" + planet4.Name + ", порядковый номер:" + planet4.Position + ", длина экватора:" + planet4.LengthOfEcvator);
            Console.WriteLine($". Эквивалентность планете Венера: {planet4.Equals(planet1)}");

        }
    }
}
