using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellarManager.model;

namespace CellarManager
{
    internal interface ILogic
    {
        public void AddBeer(Beer newBeer);
        public void AddWine(Wine newWine);
        public List<Beverage> GetAllBeverages();
    }
}
