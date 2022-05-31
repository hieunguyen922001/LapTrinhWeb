using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace PizzaPlace.Shared
{
    public  class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please proive a name")]
        public string Name { get; set; } = default;
        [Required(ErrorMessage = "Please proive a street with house number.")]
        public string Street { get; set; } = default;
        [Required(ErrorMessage = "Please proive a city")]
        public string City { get; set; } = default;

    }
}
