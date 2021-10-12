using System;
using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud__no_https.Data{
    public class AppDBContext : DbContext  {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {

        }
        public DbSet<Employee> Employees {get; set;}
    }
}


