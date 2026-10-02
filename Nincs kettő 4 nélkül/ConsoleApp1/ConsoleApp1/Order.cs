using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        private Costumer _buyer;

        private Drink _orderedDrink;

        private int _quantity;

        public Costumer Buyer { get { return _buyer; } set { _buyer = value; } }
        public Drink OrderedDrink { get { return _orderedDrink; } set { _orderedDrink = value; } }
        public int Quantity { get { return _quantity; } set { _quantity = value; } }


        public Order(Costumer buyer, Drink orderedDrink, int quantity)
        {
            _buyer = buyer;
            _orderedDrink = orderedDrink;
            _quantity = quantity;
        }

        public int TotalPrice()
        {
            
            if(Buyer.HasDiscount() == true)
            {
                return Convert.ToInt32(OrderedDrink.FinalPrice() * 0.9) * Quantity;   
            }
            return OrderedDrink.FinalPrice() * Quantity;
        }
    }
}
