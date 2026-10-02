using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Menu
    {
        private List<Drink> _drinks;

        public List<Drink> Drinks { get { return _drinks; } }

        public Menu()
        {
            _drinks = new List<Drink>();
        }

        public void AddDrink(Drink drink)
        {
            _drinks.Add(drink);
        }

        public int DeCaf()
        {
            return _drinks.Count();
        }

        public int AvragePrice()
        {
            if (_drinks.Count > 0)
                return Convert.ToInt32(_drinks.Average(x => x.FinalPrice()));
            else
                return 0;
        }



    }
}
