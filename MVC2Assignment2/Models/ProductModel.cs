using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public int Price { get; set; }
        public ICollection<SaleModel> Sale { get; set; }
    }
}