using BakeryApp.Models;
using BakeryApp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            const string ADMIN_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ROLE_ID = ADMIN_ID;

            

            //Category pies = new Category { ID = 1, Name = "pies", Image = "imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fassets.marthastewart.com%2Fstyles%2Fwmax-750%2Fd33%2Fbest-apple-pie-29254_ns_0623-1121%2Fbest-apple-pie-29254_ns_0623-1121_hz.jpg%3Fitok%3D6nE7QC9q&q=60" };
            //Category cakes = new Category { ID = 2, Name = "cakes" };
            //Category bread = new Category { ID = 3, Name = "bread" };




            //builder.Entity<Product>().HasData(
            //    new Product
            //    {
            //        ID = 1,
            //        Name = "Apple Pie",
            //        Description = "Just as good as if GrandMama made it. Made will organic ingredients and love.",
            //        Price = 39.99M,
            //        Category = pies,
            //        Image = "pie1.png"
            //    },

            //    new Product
            //    {
            //        ID = 2,
            //        Name = "Raspberry Pie",
            //        Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
            //        Price = 29.95M,
            //        Category = pies,
            //        Image = "pie2.png"
            //    },

            //    new Product
            //    {
            //        ID = 3,
            //        Name = "Blueberry Pie",
            //        Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
            //        Price = 29.95M,
            //        Category = pies,
            //        Image = "pie3.png"
            //    },

            //    new Product
            //    {
            //        ID = 4,
            //        Name = "Orange-Mango Pie",
            //        Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
            //        Price = 29.95M,
            //        Category = pies,
            //        Image = "pie4.png"
            //    },
            //    new Product
            //    {
            //        ID = 5,
            //        Name = "Green Apple Pie",
            //        Description = "This bad boy is tangy. Made will organic ingredients and love.",
            //        Price = 38.99M,
            //        Category = pies,
            //        Image = "pie5.png"
            //    },

            //    new Product
            //    {
            //        ID = 6,
            //        Name = "Burberry Pie",
            //        Description = "Each pie is made with over 500 real burberries. Made will organic ingredients and love.",
            //        Price = 29.95M,
            //        Category = pies,
            //        Image = "pie6.png"
            //    },

            //    new Product
            //    {
            //        ID = 7,
            //        Name = "Lemon-Oreo Pie",
            //        Description = "Cookies and cream with a lemon zest. Made will organic ingredients and love.",
            //        Price = 29.95M,
            //        Category = pies,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 8,
            //        Name = "Crab-Apple Pie",
            //        Description = "Not the greatest... like 2 customers like and order this one. We think they're crazy",
            //        Price = 55.99M,
            //        Category = pies,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 9,
            //        Name = "Vanilla Pie",
            //        Description = "All vanilla, everywhere, honestly, it's Paul's favorite, and he hates vanilla.",
            //        Price = 38.95M,
            //        Category = pies,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 10,
            //        Name = "Blueberry Pie",
            //        Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
            //        Price = 29.95M,
            //        Category = pies,
            //        Image = ""
            //    },

            //    //bread
            //    new Product
            //    {
            //        ID = 11,
            //        Name = "Sourdough Mega Loaf",
            //        Description = "Five Time Award Winning Bread, and signature loaf to Aboussafy's bakery. It's tangy, it's moist and we guarantee you'll love it.",
            //        Price = 19.95M,
            //        Category = bread,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 12,
            //        Name = "Kurdish-Milk Mega Loaf",
            //        Description = "Two Time Award Winning Bread, and a popular loaf at Aboussafy's bakery. It's fluffy, it's moist and we guarantee you'll come back for more.",
            //        Price = 18.95M,
            //        Category = bread,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 13,
            //        Name = "Poppy-Lemon WholeWheat",
            //        Description = "A staff favorite at Aboussafy's bakery. Tasty stuff we promise you. Give it a try. On special order only.",
            //        Price = 24.95M,
            //        Category = bread,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 14,
            //        Name = "Plain Old Pump",
            //        Description = "Pumpernickel Loaf with a twist. Anthony's personal favorite. It's dark, thick and round.",
            //        Price = 19.95M,
            //        Category = bread,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 15,
            //        Name = "Country Bread Wide",
            //        Description = "Invented by Paul Cheung's Grandmother. POM tried to buy the recipe, but we make it exclusively",
            //        Price = 29.95M,
            //        Category = bread,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 16,
            //        Name = "Stale Cheezy Bread",
            //        Description = "Stale has a bad rep. We fix that with our hard cheezy bread. A day old baguette and the finest Old Cheddar",
            //        Price = 19.95M,
            //        Category = bread,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 17,
            //        Name = "Hallah Mega Loaf",
            //        Description = "The fluffiest bread you will ever, EVER Try. It's so.... good, like really good. You won't believe it.",
            //        Price = 19.95M,
            //        Category = bread,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 18,
            //        Name = "Bacon-Dough Loaf",
            //        Description = "Seven Time Award Winning Bread..We take immitation bacon fat, mix it in the dough, presto",
            //        Price = 22.55M,
            //        Category = bread,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 19,
            //        Name = "Mystery Loaf",
            //        Description = "seven doughs mixed into one loaf. A little bit of this, and a little bit of that",
            //        Price = 22.55M,
            //        Category = bread,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 20,
            //        Name = "Bible Bread",
            //        Description = "An archeologist we know found this recipe on a dig in egypt, we took it and added olive oil.",
            //        Price = 36.55M,
            //        Category = bread,
            //        Image = ""
            //    },

            //    //cakes
            //    new Product
            //    {
            //        ID = 21,
            //        Name = "Choco-Cake",
            //        Description = "A big, bad, chocolat cake. With all the trimmings. Oh yeeeaaah!",
            //        Price = 29.95M,
            //        Category = cakes,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 22,
            //        Name = "Fairy Bread Cake",
            //        Description = "Sprinkles, white bread crumbs and vanilla icing. Your kids will love this one.",
            //        Price = 38.95M,
            //        Category = cakes,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 23,
            //        Name = "Poppy-Lemon Cake",
            //        Description = "A staff favorite at Aboussafy's bakery. Tasty stuff we promise you. Give it a try. On special order only.",
            //        Price = 24.95M,
            //        Category = cakes,
            //        Image = ""
            //    },
            //    new Product
            //    {
            //        ID = 24,
            //        Name = "Double Chocolat Oreo",
            //        Description = "Xiaotong's favorite desert, and our best seller. It's expensive because it's good.",
            //        Price = 49.95M,
            //        Category = cakes,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 25,
            //        Name = "Country Cake",
            //        Description = "Invented by Paul Cheung's Other Grandmother. POM tried to buy the recipe, she said: forget that.",
            //        Price = 129.95M,
            //        Category = cakes,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 26,
            //        Name = "Pound Cake",
            //        Description = "We didn't know what poundcake was so we made our own version. We assume the name meant pound of sugar.",
            //        Price = 29.95M,
            //        Category = cakes,
            //        Image = ""
            //    },

            //    new Product
            //    {
            //        ID = 27,
            //        Name = "Lemon Cake",
            //        Description = "The fluffiest cake you will ever, EVER Try. The secret ingredients are love and sugar.",
            //        Price = 19.95M,
            //        Category = cakes,
            //        Image = ""
            //    },

            //    new Product
            //    {

            //        ID = 28,
            //        Name = "Vegan Cheese cake",
            //        Description = "Your friends will be like, OMG this is so good, and you'll be like it's Vegan. They'll be like: YEAH RIGHT!!?",
            //        Price = 32.55M,
            //        Category = cakes,
            //        Image = ""
            //    },
            //    new Product
            //    {

            //        ID = 29,
            //        Name = "Mystery Cake",
            //        Description = "We make this one entirely blindfolded. Whatever is on the table goes it. Enjoy!",
            //        Price = 26.55M,
            //        Category = cakes,
            //        Image = ""
            //    },
            //    new Product
            //    {

            //        ID = 30,
            //        Name = "Bible Cake",
            //        Description = "An archeologist we know found this recipe on a dig in egypt, we took it and added a lot of sugar.",
            //        Price = 46.55M,
            //        Category = cakes,
            //        Image = ""
            //    });













            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "admin",
                NormalizedName = "admin"
            });


            builder.Entity<Cart>().HasKey(c => new { c.ApplicationUserId, c.ProductID });

            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();


            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = ADMIN_ID,
                    UserName = "admin@abousaffybakery.ca",
                    NormalizedUserName = "admin@abousaffybakery.ca".ToUpper(),
                    FirstName = "admin",
                    LastName = "admin",
                    Email = "admin@abousaffybakery.ca",
                    NormalizedEmail = "admin@abousaffybakery.ca".ToUpper(),
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "P4ssword!")
                });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }


        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Contact> Contact { get; set; }
    }
}
