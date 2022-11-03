using System;

namespace HomeWork6_OTUS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string planet1 = "Земля";
            string planet2 = "Лимония";
            string planet3 = "Марс";

            var myCatalog = new CatalogOfPlanet();

            var request1 = myCatalog.GetPlanet(planet1);
            var request2 = myCatalog.GetPlanet(planet2);
            var request3 = myCatalog.GetPlanet(planet3);

            if (request1.message == null)
                Console.WriteLine($"{planet1}. Порядковый номер - {request1.pos}, длина экватора - {request1.legth}");
            else
                Console.WriteLine($"{planet1}. " + request1.message);

            if (request2.message == null)
                Console.WriteLine($"{planet2}. Порядковый номер - {request2.pos}, длина экватора - {request2.legth}");
            else
                Console.WriteLine($"{planet2}. " + request2.message);

            if (request3.message == null)
                Console.WriteLine($"{planet3}. Порядковый номер - {request3.pos}, длина экватора - {request3.legth}");
            else
                Console.WriteLine($"{planet3}. " + request3.message);



        }

        
    }
}
