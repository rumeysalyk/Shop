using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DataAccess.EntityFramework
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<OnlineShopDbContext>();

            context.Database.Migrate();
            if (!context.Categories.Any())
            {
                var categories = new[]
                {
                    new Category(){CategoryName="Kitap"},
                    new Category(){CategoryName="Dergi"},
                    new Category(){CategoryName="Elektronik"},
                };

                context.Categories.AddRange(categories);

                context.SaveChanges();
            }
            if (!context.Products.Any())
            {
                var products = new[]
                {
                    new Product(){ProductName="Mutlu Prens",Price=25,CategoryId=1,Description="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Doloribus quidem adipisci, in quam incidunt asperiores? Ea sed quidem voluptatibus non quas suscipit quod dolores. Quam qui impedit possimus commodi non!"},
                    new Product(){ProductName="Mesnevi",Price=85,CategoryId=1,Description="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Doloribus quidem adipisci, in quam incidunt asperiores? Ea sed quidem voluptatibus non quas suscipit quod dolores. Quam qui impedit possimus commodi non!"},
                    new Product(){ProductName="Kamera",Price=1500,CategoryId=3,Description="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Doloribus quidem adipisci, in quam incidunt asperiores? Ea sed quidem voluptatibus non quas suscipit quod dolores. Quam qui impedit possimus commodi non!"},
                    new Product(){ProductName="Parende Dergisi",Price=15, CategoryId=2,Description="Lorem ipsum dolor sit, amet consectetur adipisicing elit. Doloribus quidem adipisci, in quam incidunt asperiores? Ea sed quidem voluptatibus non quas suscipit quod dolores. Quam qui impedit possimus commodi non!"},
                };
                context.Products.AddRange(products);

                context.SaveChanges();
            }




        }
    }
}
