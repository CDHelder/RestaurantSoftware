using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Restaurant_Core
{
    public class Order
    {   
        [Key]
        public int OrderId { get; set; }

        [ForeignKey("Table")]
        public int TableId { get; set; }

        public int OrderProductsId { get; set; }
        public OrderProducts OrderProducts { get; set; }

    }
}
