using System;
using System.Collections.Generic;

namespace Orcus.Extension.Testing
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }
        public Decimal? UnitPrice { get; set; }
        public bool OutOfStock { get; set; }
        public DateTime StokDateTime { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public static class DataSource
    {
        public static IList<Category> Categories
        {
            get
            {
                List<Category> catList = new List<Category>
                {
                    new Category { CategoryID = 1, CategoryName = "Cars" },
                    new Category { CategoryID = 2, CategoryName = "Travels" },
                    new Category { CategoryID = 3, CategoryName = "Games" }
                };
                return catList;
            }
        }

        public static IList<Product> Products
        {
            get
            {
                List<Product> prodList = new List<Product>
                {
                    new Product { ProductID = 1, ProductName = "Bath Rug, Soft", CategoryID = 1, UnitPrice = 24.5m, StokDateTime = DateTime.Now },
                    new Product { ProductID = 2, ProductName = "Shower Curtain", CategoryID = 1, UnitPrice = 30.99m, StokDateTime = DateTime.Now.AddDays(1) },
                    new Product { ProductID = 3, ProductName = "Soap Dispenser", CategoryID = 1, UnitPrice = 12.4m, OutOfStock = true, StokDateTime = DateTime.Now.AddHours(2) },
                    new Product { ProductID = 4, ProductName = "Toilet Tissue", CategoryID = 1, UnitPrice = 15, StokDateTime = DateTime.Now.AddMilliseconds(34) },
                    new Product { ProductID = 5, ProductName = "Branket", CategoryID = 2, UnitPrice = 60, StokDateTime = DateTime.Now.AddSeconds(23) },
                    new Product { ProductID = 6, ProductName = "Mattress Protector", CategoryID = 2, UnitPrice = 30.4m, OutOfStock = true, StokDateTime = DateTime.Now.AddYears(2) },
                    new Product { ProductID = 7, ProductName = "Sheet Set", CategoryID = 2, UnitPrice = 40.69m },
                    new Product { ProductID = 8, ProductName = "Baking Pan", CategoryID = 3, UnitPrice = 10.99m },
                    new Product { ProductID = 9, ProductName = "Coffee Maker", CategoryID = 3, UnitPrice = 49.39m },
                    new Product { ProductID = 10, ProductName = "Knife Set", CategoryID = 3, UnitPrice = 70 },
                    new Product { ProductID = 11, ProductName = "Pressure Cooker", CategoryID = 3, UnitPrice = 90.5m, OutOfStock = true },
                    new Product { ProductID = 12, ProductName = "Water Pitcher", CategoryID = 3, UnitPrice = 29.99m }
                };
                return prodList;
            }
        }
    }
}
