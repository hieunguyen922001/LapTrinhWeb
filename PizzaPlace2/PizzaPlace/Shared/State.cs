using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class State
    {
        public static Menu Menu { get; set; } = new Menu();
        public ShoppingBasket Basket { get; } = new ShoppingBasket();
        public UI UI { get; set; } = new UI();
        public decimal TotalPrice
        => Basket.Orders.Sum(id => Menu.GetPizza(id)!.Price);
    }
}
