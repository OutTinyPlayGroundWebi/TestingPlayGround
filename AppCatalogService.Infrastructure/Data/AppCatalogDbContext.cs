using AppCatalogService.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalogService.Infrastructure.Data
{
    public class AppCatalogDbContext : DbContext
    {
        public AppCatalogDbContext(DbContextOptions<AppCatalogDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationEntity> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
