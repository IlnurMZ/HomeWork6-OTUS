using System;

namespace HomeWork6_OTUS_3
{
    public class Program
    {        
        static void Main(string[] args)
        {
            string planet1 = "Земля";
            string planet2 = "Лимония";
            string planet3 = "Марс";

            string planet4 = "Венера";
            string planet5 = "Лимония";
            string planet6 = "Марс";

            var myCatalog = new CatalogOfPlanet();      
            // Программа 3
            var request1 = myCatalog.GetPlanet(planet1, (string mes) => CatalogOfPlanet.count % 3 == 0 ? "Вы спрашиваете слишком часто" : null);              
            
            var request2 = myCatalog.GetPlanet(planet2, (string mes) => CatalogOfPlanet.count % 3 == 0 ? "Вы спрашиваете слишком часто" : null);          

            var request3 = myCatalog.GetPlanet(planet3, (string mes) => CatalogOfPlanet.count % 3 == 0 ? "Вы спрашиваете слишком часто" : null);

            // Пункт со *
            var request4 = myCatalog.GetPlanet(planet4, (string mes) => mes == "Лимония" ? "Это запретная планет" : null);

            var request5 = myCatalog.GetPlanet(planet5, (string mes) => mes == "Лимония" ? "Это запретная планет" : null);

            var request6 = myCatalog.GetPlanet(planet6, (string mes) => mes == "Лимония" ? "Это запретная планет" : null);

            // Вывод результатов
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

            if (request4.message == null)
                Console.WriteLine($"{planet4}. Порядковый номер - {request4.pos}, длина экватора - {request4.legth}");
            else
                Console.WriteLine($"{planet4}. " + request4.message);

            if (request5.message == null)
                Console.WriteLine($"{planet5}. Порядковый номер - {request5.pos}, длина экватора - {request5.legth}");
            else
                Console.WriteLine($"{planet5}. " + request5.message);

            if (request6.message == null)
                Console.WriteLine($"{planet6}. Порядковый номер - {request6.pos}, длина экватора - {request6.legth}");
            else
                Console.WriteLine($"{planet6}. " + request6.message);
        }

        // Для себя

        //public static string CheckCountRequest(string mes)
        //{
        //    if (CatalogOfPlanet.count  % 3 == 0)
        //        return "Вы спрашиваете слишком часто";
        //    else if (mes == "Лимония")
        //        return "Это запретная планета";
        //    else return null;
        //}

        // Можно лямбду записать так
        //var request1 = myCatalog.GetPlanet(planet1, (string mes) =>
        //{
        //    if (CatalogOfPlanet.count % 3 == 0)
        //        return "Вы спрашиваете слишком часто";
        //    else if (mes == "Лимония")
        //        return "Это запретная планета";
        //    else return null;
        //});

        //CatalogOfPlanet.count % 3 == 0 ? "Вы спрашиваете слишком часто" : (mes == "Лимония" ? "Это запретная планета" : null));
    }
}
