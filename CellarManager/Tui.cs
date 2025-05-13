using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellarManager.model;

namespace CellarManager
{
    internal class Tui
    {

        private ILogic _logic;
        public Tui(ILogic logic)
        {
            _logic = logic;
        }

        internal void Start()
        {
            _logic.AddBeer("Pilsner", 5.0, BeerType.Pilsner, "Germany", 2020, 40);
            _logic.AddBeer("IPA", 6.5, BeerType.IPA, "USA", 2021, 60);
            _logic.AddWine("Chardonnay", 13.5, WineType.White, "France", 2019, "Chardonnay");
            _logic.AddWine("Merlot", 14.0, WineType.Red, "Italy", 2018, "Merlot");
            _logic.AddWine("Sauvignon Blanc", 12.5, WineType.White, "New Zealand", 2020, "Sauvignon Blanc");

            foreach (var bev in _logic.GetBeverages())
            {
                Console.WriteLine(bev.ToString());
            }
        }
    }
}
