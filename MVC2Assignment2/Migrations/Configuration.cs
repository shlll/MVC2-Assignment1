namespace MVC2Assignment2.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MVC2Assignment2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC2Assignment2.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "MVC2Assignment2.Models.ApplicationDbContext";
        }

        protected override void Seed(MVC2Assignment2.Models.ApplicationDbContext context)
        {
            var employeeManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var saleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!context.Roles.Any(s => s.Name == "Employee"))
            {
                saleManager.Create(new IdentityRole { Name = "Employee" });
            }
        }
    }
}
