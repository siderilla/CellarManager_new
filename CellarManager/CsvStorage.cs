using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellarManager.model;

namespace CellarManager
{
    internal class CsvStorage : IStorage
    {
        private List<Beverage> beverages = new List<Beverage>(); // Field to store beverages

        public List<Beverage> LoadAllBeverages()
        {
            if (!File.Exists("beverages.csv"))
            {
                return new List<Beverage>();
            }
            string[] lines = File.ReadAllLines("beverages.csv");
            beverages = new List<Beverage>(); // Initialize the beverages list
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts[0] == "Beer")
                {
                    var beer = new Beer
                    {
                        Name = parts[1],
                        Alcohol = double.Parse(parts[2]),
                        Country = parts[3],
                        Year = int.Parse(parts[4]),
                        Type = (BeerType)Enum.Parse(typeof(BeerType), parts[5]),
                        IBU = int.Parse(parts[6])
                    };
                    beverages.Add(beer);
                }
                else if (parts[0] == "Wine")
                {
                    var wine = new Wine
                    {
                        Name = parts[1],
                        Alcohol = double.Parse(parts[2]),
                        Country = parts[3],
                        Year = int.Parse(parts[4]),
                        Type = (WineType)Enum.Parse(typeof(WineType), parts[5]),
                        Grape = parts[6]
                    };
                    beverages.Add(wine);
                }
            }
            return beverages;
        }

        public void SaveAllBeverages(List<Beverage> beverages)
        {
            var builder = new StringBuilder();
            builder.AppendLine("Class,Name,Alcohol,Country,Year,Type,IBU,Grape");
            foreach (var bev in beverages)
            {
                builder.AppendLine(bev.CsvFormat());
            }
            File.WriteAllText("beverages.csv", builder.ToString());
        }

        public void DeleteBeverage(int index)
        {
            if (index >= 0 && index < beverages.Count)
            {
                beverages.RemoveAt(index); // Use the beverages field directly
                SaveAllBeverages(beverages); // Call SaveAllBeverages with the beverages field
            }
            else
            {
                Console.WriteLine("Invalid index. No beverage deleted.");
            }
        }
    }
}
