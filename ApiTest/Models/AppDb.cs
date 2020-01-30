using System;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Models
{
    public class AppDb : DbContext
    {
        public DbSet<Todos> Todo {get;set;}

        public AppDb(DbContextOptions options) : base(options)
        {
            
        }
    }
}