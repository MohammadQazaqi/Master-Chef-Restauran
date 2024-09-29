using Master_Chef_Restaurant.Entities.Ingredients;
using Master_Chef_Restaurant.Entities.Orders;
using System.ComponentModel.DataAnnotations.Schema;

namespace Master_Chef_Restaurant.Entities.Meals
{
    public class Meal
    {
        public int Id { get; set; }

        public string Name { get; set; }


        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        public List<Ingredient> Ingredients { get; set; } = [];

        public List<Order> Orders { get; set; }
    }

}
