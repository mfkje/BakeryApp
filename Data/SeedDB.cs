using BakeryApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;


namespace BakeryApp.Data
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string testUserPw="Password1!")
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // For sample purposes seed both with the same password.
                // Password is set with the following:
                // dotnet user-secrets set SeedUserPW <pw>
                // The admin user can do anything



                SeedDB(context);
            }
        }
        public static void SeedDB(ApplicationDbContext context)
        {
            if (context.Products.Any() || context.Categories.Any())
            {
                return;   // DB has been seeded
            }
            //context.Categories.AddRange(new Category { Name = "pies" }, new Category { Name = "cakes" }, new Category { Name = "bread" });
            
            Category pies = new Category { Name = "pies", Image = "imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fassets.marthastewart.com%2Fstyles%2Fwmax-750%2Fd33%2Fbest-apple-pie-29254_ns_0623-1121%2Fbest-apple-pie-29254_ns_0623-1121_hz.jpg%3Fitok%3D6nE7QC9q&q=60" };
            Category cakes = new Category { Name = "cakes" };
            Category bread = new Category { Name = "bread" };

            context.Products.AddRange(
                //pies
                new Product
                {
                    Name = "Apple Pie",
                    Description = "Just as good as if GrandMama made it. Made will organic ingredients and love.",
                    Price = 39.99M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Raspberry Pie",
                    Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
                    Price = 29.95M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Blueberry Pie",
                    Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
                    Price = 29.95M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Orange-Mango Pie",
                    Description = "It's not just a personal computer it's also our top selling pie. Made will organic ingredients and love.",
                    Price = 29.95M,
                    Category = pies,
                    Image = "pie1.png"
                },
                new Product
                {
                    Name = "Green Apple Pie",
                    Description = "This bad boy is tangy. Made will organic ingredients and love.",
                    Price = 38.99M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Burberry Pie",
                    Description = "Each pie is made with over 500 real burberries. Made will organic ingredients and love.",
                    Price = 29.95M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Mud Pie",
                    Description = "It chocolat not mud, we promise. Made will organic ingredients and love.",
                    Price = 29.95M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Lemon-Oreo Pie",
                    Description = "Cookies and cream with a lemon zest. Made will organic ingredients and love.",
                    Price = 29.95M,
                    Category = pies,
                    Image = "pie1.png"
                },
                new Product
                {
                    Name = "Crab-Apple Pie",
                    Description = "Not the greatest... like 2 customers like and order this one. We think they're crazy",
                    Price = 55.99M,
                    Category = pies,
                    Image = "pie1.png"
                },

                new Product
                {
                    Name = "Vanilla Pie",
                    Description = "All vanilla, everywhere, honestly, it's Paul's favorite, and he hates vanilla.",
                    Price = 38.95M,
                    Category = pies,
                    Image = "pie1.png"
                },

                //bread
                new Product
                {
                    Name = "Sourdough Mega Loaf",
                    Description = "Five Time Award Winning Bread, and signature loaf to Aboussafy's bakery. It's tangy, it's moist and we guarantee you'll love it.",
                    Price = 19.95M,
                    Category = bread,
                    Image = "bread.png"
                },
                new Product
                {
                    Name = "Kurdish-Milk Mega Loaf",
                    Description = "Two Time Award Winning Bread, and a popular loaf at Aboussafy's bakery. It's fluffy, it's moist and we guarantee you'll come back for more.",
                    Price = 18.95M,
                    Category = bread,
                    Image = "bread.png"
                },
                new Product
                {
                    Name = "Poppy-Lemon WholeWheat",
                    Description = "A staff favorite at Aboussafy's bakery. Tasty stuff we promise you. Give it a try. On special order only.",
                    Price = 24.95M,
                    Category = bread,
                    Image = "bread.png"
                },
                new Product
                {
                    Name = "Plain Old Pump",
                    Description = "Pumpernickel Loaf with a twist. Anthony's personal favorite. It's dark, thick and round.",
                    Price = 19.95M,
                    Category = bread,
                    Image = "bread.png"
                },

                new Product
                {
                    Name = "Country Bread Wide",
                    Description = "Invented by Paul Cheung's Grandmother. POM tried to buy the recipe, but we make it exclusively",
                    Price = 29.95M,
                    Category = bread,
                    Image = "bread.png"
                },

                new Product
                {
                    Name = "Stale Cheezy Bread",
                    Description = "Stale has a bad rep. We fix that with our hard cheezy bread. A day old baguette and the finest Old Cheddar",
                    Price = 19.95M,
                    Category = bread,
                    Image = "bread.png"
                },

                new Product
                {
                    Name = "Hallah Mega Loaf",
                    Description = "The fluffiest bread you will ever, EVER Try. It's so.... good, like really good. You won't believe it.",
                    Price = 19.95M,
                    Category = bread,
                    Image = "bread.png"
                },

                new Product
                {
                    Name = "Bacon-Dough Loaf",
                    Description = "Seven Time Award Winning Bread..We take immitation bacon fat, mix it in the dough, presto",
                    Price = 22.55M,
                    Category = bread,
                    Image = "bread.png"
                },
                new Product
                {
                    Name = "Mystery Loaf",
                    Description = "seven doughs mixed into one loaf. A little bit of this, and a little bit of that",
                    Price = 22.55M,
                    Category = bread,
                    Image = "bread.png"
                },
                new Product
                {
                    Name = "Bible Bread",
                    Description = "An archeologist we know found this recipe on a dig in egypt, we took it and added olive oil.",
                    Price = 36.55M,
                    Category = bread,
                    Image = "bread.png"
                },

                //cakes
                new Product
                {
                    Name = "Choco-Cake",
                    Description = "A big, bad, chocolat cake. With all the trimmings. Oh yeeeaaah!",
                    Price = 29.95M,
                    Category = cakes,
                    Image = "cake.png"
                },
                new Product
                {
                    Name = "Fairy Bread Cake",
                    Description = "Sprinkles, white bread crumbs and vanilla icing. Your kids will love this one.",
                    Price = 38.95M,
                    Category = cakes,
                    Image = "cake.png"
                },
                new Product
                {
                    Name = "Poppy-Lemon Cake",
                    Description = "A staff favorite at Aboussafy's bakery. Tasty stuff we promise you. Give it a try. On special order only.",
                    Price = 24.95M,
                    Category = cakes,
                    Image = "cake.png"
                },
                new Product
                {
                    Name = "Double Chocolat Oreo",
                    Description = "Xiaotong's favorite desert, and our best seller. It's expensive because it's good.",
                    Price = 49.95M,
                    Category = cakes,
                    Image = "cake.png"
                },

                new Product
                {
                    Name = "Country Cake",
                    Description = "Invented by Paul Cheung's Other Grandmother. POM tried to buy the recipe, she said: forget that.",
                    Price = 129.95M,
                    Category = cakes,
                    Image = "cake.png"
                },

                new Product
                {
                    Name = "Pound Cake",
                    Description = "We didn't know what poundcake was so we made our own version. We assume the name meant pound of sugar.",
                    Price =29.95M,
                    Category = cakes,
                    Image = "cake.png"
                },

                new Product
                {
                    Name = "Lemon Cake",
                    Description = "The fluffiest cake you will ever, EVER Try. The secret ingredients are love and sugar.",
                    Price = 19.95M,
                    Category = cakes,
                    Image = "cake.png"
                },

                new Product
                {
                    Name = "Vegan Cheese cake",
                    Description = "Your friends will be like, OMG this is so good, and you'll be like it's Vegan. They'll be like: YEAH RIGHT!!?",
                    Price = 32.55M,
                    Category = cakes,
                    Image = "cake.png"
                },
                new Product
                {
                    Name = "Mystery Cake",
                    Description = "We make this one entirely blindfolded. Whatever is on the table goes it. Enjoy!",
                    Price = 26.55M,
                    Category = cakes,
                    Image = "cake.png"
                },
                new Product
                {
                    Name = "Bible Cake",
                    Description = "An archeologist we know found this recipe on a dig in egypt, we took it and added a lot of sugar.",
                    Price = 46.55M,
                    Category = cakes,
                    Image = "cake.png"
                }

             );
            context.SaveChanges();
        }
    }
}


