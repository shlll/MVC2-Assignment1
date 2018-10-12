using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Models
{
    public class SaleModel
    {
        public int Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public int CustomerId { get; set; }
        public virtual CustomerModel Customer { get; set; }
        public int StoreLocationId { get; set; }
        public virtual StoreLocationModel StoreLocation { get; set; }
        public int ProductId { get; set; }
        public virtual ProductModel Product { get; set; }
        public int EmployeeId { get; set; }
        public virtual ApplicationUser Employee { get; set; }
        public int SalesId { get; set; }
        public virtual ApplicationUser Sales { get; set; }
    }
}