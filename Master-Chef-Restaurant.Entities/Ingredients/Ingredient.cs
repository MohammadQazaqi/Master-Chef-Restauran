﻿using Master_Chef_Restaurant.Entities.Meals;
using System.ComponentModel.DataAnnotations.Schema;

namespace Master_Chef_Restaurant.Entities.Ingredients
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        public List<Meal> Meals { get; set; } = [];
    }
}
