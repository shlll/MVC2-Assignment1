using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Project()
        {
            Employees = new HashSet<ApplicationUser>();
        }
        public virtual ICollection<ApplicationUser> Employees { get; set; }
        public virtual ICollection<SaleModel> Sales { get; set; }
    }
}