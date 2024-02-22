﻿using Microsoft.EntityFrameworkCore;
using WebApiAuthors.Entities;
namespace WebApiAuthors
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Author> Authors { get; set; }
    }
}
