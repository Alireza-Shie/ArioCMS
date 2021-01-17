using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ario.CMS.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Ario.CMS.Data.Context
{
    public class ArioCMSContext : IdentityDbContext
    {
        public ArioCMSContext(DbContextOptions<ArioCMSContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<PageGroups> PageGroups { get; set; }
        public DbSet<PageComment> PageComments { get; set; }
    }
}
