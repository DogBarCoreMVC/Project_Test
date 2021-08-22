using Microsoft.EntityFrameworkCore;
using Project_Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Test.Data
{
    public class DbContextCustomer : DbContext
    {
        public DbContextCustomer(DbContextOptions<DbContextCustomer>options ):base(options)
        {
            
        }
        public DbSet<Customers> customersTbl { get; set; }
    }
}
