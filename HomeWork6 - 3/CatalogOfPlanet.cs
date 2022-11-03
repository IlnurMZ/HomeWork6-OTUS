using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6_OTUS_3
{
    public class CatalogOfPlanet
    {
        List<Planet> catalog;
        public static int count = 0;
        public CatalogOfPlanet()
        {
            catalog = new List<Planet>(3);
            catalog.Add(new Planet("Венера", 2, 12100, null));
            catalog.Add(new Planet("Земля", 3, 40075, catalog[0]));
            catalog.Add(new Planet("Марс", 4, 21344, catalog[1]));
        }

        public (int pos, int legth, string message) GetPlanet(string name, Func<string, string> PlanetValidator)
        {            
            count++;
            string str = PlanetValidator(name);
            if (str != null)
                return (pos: -1, legth: 0, message: str);

            return name switch
            {
                "Венера" => (pos: catalog[0].Position, legth: catalog[0].LengthOfEcvator, message: str),
                "Земля" => (pos: catalog[1].Position, legth: catalog[1].LengthOfEcvator, message: str),
                "Марс" => (pos: catalog[2].Position, legth: catalog[2].LengthOfEcvator, message: str),
                _ => (pos: -1, legth: 0, message: "Не удалось найти планету")                
            };
        }
    }
}
