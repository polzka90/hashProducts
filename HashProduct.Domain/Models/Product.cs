using System;
using System.Collections.Generic;
using System.Text;

namespace HashProduct.Domain.Models
{
    public class Product
    {
        public string Id { get; set; }
        public int PriceInCents { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Discount Discount { get; set; }
    }
}
