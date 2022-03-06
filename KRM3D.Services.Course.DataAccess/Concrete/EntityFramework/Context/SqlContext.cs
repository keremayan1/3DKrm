using KRM3D.Core.DataAccess.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRM3D.Services.Course.DataAccess.Concrete.EntityFramework.Context
{
    public class SqlContext : EfContextBase
    {
        public SqlContext(DbContextOptions<SqlContext> options, IConfiguration configuration) : base(options, configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlConnectionStrings"));
        }
        public DbSet<Entities.Concrete.Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entities.Concrete.Course>().OwnsOne(x => x.Feature);
            base.OnModelCreating(modelBuilder);
               

        }

    }
}
