using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThePizzaChallenge.Models;

namespace ThePizzaChallenge.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Pizza> Pizzas {get; set;}
        public DbSet<Ingredients> Ingredientses {get; set;}


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


    }
}
