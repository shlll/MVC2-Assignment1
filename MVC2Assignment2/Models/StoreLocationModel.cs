using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Models
{
    public class StoreLocationModel
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public ICollection<SaleModel> Sale { get; set; }
    }
}