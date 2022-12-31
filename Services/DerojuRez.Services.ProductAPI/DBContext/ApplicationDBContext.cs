using Microsoft.EntityFrameworkCore;
using System;
namespace DerojuRez.Services.ProductAPI;

public class ApplicationDbContext : DbContext 
{
    public ApplicationDBContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}