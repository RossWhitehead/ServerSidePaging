namespace ServerSidePaging.Data.Migrations
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServerSidePaging.Data.ServerSidePagingDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ServerSidePaging.Data.ServerSidePagingDbContext context)
        {
            context.ProductCategories.AddOrUpdate(
                pc => pc.ProductCategoryId,
                new ProductCategory { ProductCategoryId = 1, Name = "Road Bikes" },
                new ProductCategory { ProductCategoryId = 2, Name = "Mountain Bikes" }
                );

            context.Products.AddOrUpdate(
                pc => pc.ProductId,
                new Product { ProductId = 1, Name = "Kinesis Aithein", Description = "Lightweight race focused road bike", ProductCategoryId = 1, Price = 999.99M },
                new Product { ProductId = 2, Name = "Kinesis Sync", Description = "The perfect balance of the Kinesis Sync frame is reflected in its trail accuracy, power delivery and climbing surge.", ProductCategoryId = 2, Price = 1999.99M },
                new Product { ProductId = 3, Name = "Planet X EC-130E", Description = "Fast aero road design", ProductCategoryId = 1, Price = 1999.99M },
                new Product { ProductId = 4, Name = "On-One Codeine", Description = "The SRAM GX1 equipped Codeine 29er redefines the price -performance equation in the all-mountain MTB market segment. There's none more capable.", ProductCategoryId = 2, Price = 1999.99M },
                new Product { ProductId = 5, Name = "Cinelli Mash Histogram", Description = "The Mash Histogram is an aggressive single speed bike that displays a stealth look and features bullhorn (Mash) handlebars, Carbon forks, and Cinelli components. A great bike that appeals to both fixie and track riders.", ProductCategoryId = 1, Price = 1999.99M },
                new Product { ProductId = 6, Name = "Verenti Substance Sora", Description = "The 2016 Verenti Substance is designed to attack the gravel, the cyclocross tracks or even the everyday commute, using a 4130 butted chromoly frame with comfort and confidence inspiring geometry, the Substance is a fun and tough all-rounder.", ProductCategoryId = 1, Price = 1999.99M }
                );
        }
    }
}
