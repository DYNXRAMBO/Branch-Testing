using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Midterm
{
    
    public class AppDbContext : DbContext
    {
       
       
        private const string ConnectionString = @"Data Source=MyFirstEfCoreDb.db";

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlite(ConnectionString); 
        }        

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors {get; set;}     
    }    
}