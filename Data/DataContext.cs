using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext	// DbContext is a class in EntityFrameworkCore
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }       

        public DbSet<Character> Characters => Set<Character>();	
    }
}