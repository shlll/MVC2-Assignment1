using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MVC2Assignment2.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public ApplicationUser()
        {
            Projects = new HashSet<Project>();
            EmployeeApproveTheSales = new HashSet<SaleModel>();
            SalesEmployees = new HashSet<SaleModel>();
        }
        public ICollection<Project> Projects { get; set; }
        [InverseProperty("Employee")]
        public ICollection<SaleModel> EmployeeApproveTheSales { get; set; }
        [InverseProperty("Sales")]
        public ICollection<SaleModel> SalesEmployees { get; set; }
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<MVC2Assignment2.Models.SaleModel> SaleModels { get; set; }

        public System.Data.Entity.DbSet<MVC2Assignment2.Models.CustomerModel> CustomerModels { get; set; }

        public System.Data.Entity.DbSet<MVC2Assignment2.Models.EmployeeModel> EmployeeModels { get; set; }

        public System.Data.Entity.DbSet<MVC2Assignment2.Models.ProductModel> ProductModels { get; set; }

        public System.Data.Entity.DbSet<MVC2Assignment2.Models.StoreLocationModel> StoreLocationModels { get; set; }
    }
}