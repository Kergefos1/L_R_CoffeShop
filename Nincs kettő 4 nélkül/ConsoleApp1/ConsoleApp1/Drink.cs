using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Drink
    {
        private string _name;

        private int _price;

        private bool _isLarge;

        private bool _isDecaf;


        public string Name { get { return _name; } set { _name = value; } }

        public int Price { get { return _price; } set { _price = value; } }
        public bool IsLarge { get { return _isLarge; } set { _isLarge = value; } }
        public bool IsDecaf { get { return _isDecaf; } set { _isDecaf = value; } }


        public Drink(string name, int price, bool isLarge, bool isDecaf)
        {
            _name = name;
            _price = price;
            _isLarge = isLarge;
            _isDecaf = isDecaf;
        }

        public int FinalPrice()
        {
            
            if( IsLarge == true)
            {
                return Convert.ToInt32( Price * 0.7);
            }
            return Price;
        }

        public string Describe()
        {
            string i = "";
            if(IsLarge == false && IsDecaf == false)
            {
                return i = $"{Name}, kicsi , koffeinmentes: {FinalPrice() } Ft”.";
            }
            else if(IsDecaf == true && IsLarge == true)
            {
                return i = $"{Name}, Nagy , koffeines: {FinalPrice()}”.";
            }
            else if (IsDecaf == true && IsLarge == false)
            {
                return i = $"{Name}, Nagy , koffeinmentes: {FinalPrice()}”.";
            }
            else
            {
                return  i = $"{Name}, kicsi , koffeines: {FinalPrice()} Ft”.";
            }
            
        }



    }
}
