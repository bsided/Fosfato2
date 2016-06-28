using Fosfato.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fosfato.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
              : base("DefaultConnection")
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=.; Database=NORTHWIND; Trusted_Connection=False; User=ahmedamin; Password=sasa2206; MultipleActiveResultSets=true;");
        //}

        public DbSet<Company> Company { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Currency> Currency { get; set; }
    }
}
