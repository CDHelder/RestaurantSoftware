using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Core
{
    public class OrderProducts
    {
        public int OrderProductsId { get; set; }
        public bool DrinksReady { get; set; }
        public bool FoodReady { get; set; }

        //Moet er ook worden aangegeven of de drankjes en het eten zijn bezorgd?

        public int OrderId { get; set; }
        public ICollection<Product> ProductsInOrder { get; set; }
    }
}
