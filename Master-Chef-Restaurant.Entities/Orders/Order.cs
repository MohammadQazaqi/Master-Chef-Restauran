using Master_Chef_Restaurant.Entities.Customers;
using Master_Chef_Restaurant.Entities.Meals;
using Master_Chef_Restaurant.Utils.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Master_Chef_Restaurant.Entities.Orders
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderTime { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal TotalPrice { get; set; }


        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public string? Note { get; set; }

        public Location Location { get; set; }

        public List<Meal> Meals { get; set; } = [];
    }
}
