using System;
using DerojuRez.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
 

namespace ProductAPI.DbContextOptions
{
public class ApplicationDbContext : DbContext 
{
     public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    public DbSet<Product> Products { get; set; }
}
}