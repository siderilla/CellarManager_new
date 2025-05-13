using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CellarManager.model;

namespace CellarManager
{
    internal class JsonStorage : IStorage
    {
        private const string FileName = "beverages.json";

        public List<Beverage> LoadAllBeverages()
        {
            if (!File.Exists(FileName))
                return new List<Beverage>();

            var json = File.ReadAllText(FileName);

            var options = new JsonSerializerOptions
            {
                Converters = { new BeverageConverter() },
                PropertyNameCaseInsensitive = true
            };

            return JsonSerializer.Deserialize<List<Beverage>>(json, options) ?? new List<Beverage>();
        }

        public void SaveAllBeverages(List<Beverage> beverages)
        {
            var options = new JsonSerializerOptions
            {
                Converters = { new BeverageConverter() },
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(beverages, options);
            File.WriteAllText(FileName, json);
        }
    }
}
