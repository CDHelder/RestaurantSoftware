using System.ComponentModel.DataAnnotations;

namespace Restaurant_Core
{
    public enum FoodType
    {
        Drinks,
        Appetizers,
        Snacks,
        Main,
        Dessert
    }

    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public FoodType FoodType { get; set; }
        public double Price { get; set; }
    }
}