using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HashProduct.Domain.Entities
{
    [Table("tbl_products")]
    public class ProductEntity
    {
        [Key]
        public string id { get; set; }
        public int price_in_cents { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
