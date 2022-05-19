using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreTest
{
    public class Dish
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        public string? Notes { get; set; }

        public int? Stars { get; set; }

        public List<DishIngredient> Ingredients { get; set; } = new();
    }

    public class DishIngredient
    {
        public int Id { get; set; }
        public string  Description { get; set; } = string.Empty;

        public string UnitOfMeasure { get; set; } = string.Empty;

        [Column(TypeName = "decimal(5, 2)")]
        public decimal Amount { get; set; }

        public Dish? Dish { get; set; }
        
        public int DishId { get; set; }
    }
}
