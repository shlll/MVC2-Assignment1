using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RegistrationNumber { get; set; }
        public ICollection<SaleModel> Sale { get; set; }
    }
}