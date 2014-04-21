namespace MVC5Garden.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MVC5Garden.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MVC5Garden.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MVC5Garden.Models.ApplicationDbContext";
        }

        protected override void Seed(MVC5Garden.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            //var hasher = new PasswordHasher();
            //context.Users.AddOrUpdate(
            //  p => p.UserName,
            //  new ApplicationUser { UserName = "Andrew Peters", PasswordHash = hasher.HashPassword("AndrewPeters") },
            //  new ApplicationUser { UserName = "Brice Lambson", PasswordHash = hasher.HashPassword("BriceLambson") },
            //  new ApplicationUser { UserName = "Rowan Miller", PasswordHash = hasher.HashPassword("RowanMiller") }
            //);

            if (context.Users.Count() == 0)
            {
                // Implement IUserStore
                var store = new UserStore<ApplicationUser>(context);

                // UserManager is part of the core identity features.
                var manager = new UserManager<ApplicationUser>(store);

                var user = new ApplicationUser { UserName = "KahneRaja" };
                manager.Create(user, "Password1");
            }

        }
    }
}
