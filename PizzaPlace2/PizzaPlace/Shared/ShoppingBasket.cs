using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPlace.Shared
{
    public class ShoppingBasket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Orders { get; set; } = new List<int>();
        public bool HasPaid { get; set; }
        public void RemoveAt(int pos)
        => Orders.RemoveAt(pos);
        public void Add(int pizzaId)
            => Orders.Add(pizzaId);
    }
}
