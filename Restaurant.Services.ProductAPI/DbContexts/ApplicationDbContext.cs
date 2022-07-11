﻿using Microsoft.EntityFrameworkCore;
using Restaurant.Services.ProductAPI.Models;

namespace Restaurant.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
           
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                ProductName = "Samosa",
                Price = 15,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                ProductName = "Paneer Tikka",
                Price = 13.99,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                ProductName = "Sweet Pie",
                Price = 10.99,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "",
                CategoryName = "Dessert"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                ProductName = "Pav Bhaji",
                Price = 15,
                ProductDescription = "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.",
                ImageUrl = "",
                CategoryName = "Entree"
            });
        }
    }
}
