using App.Domain.Core.AdministratorAgg.Entities;
using App.Domain.Core.BaseService.Entities;
using App.Domain.Core.CustomerAgg.Entities;
using App.Domain.Core.ExpertAgg.Entities;
using App.Domain.Core.OrderAgg.Entities;
using App.Domain.Core.SuggestionAgg.Entities;
using App.Infrastructures.Database.SqlServer.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Database.SqlServer.Data
{
    public class AppDbContext:DbContext
    {
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SecondaryCategory> SecondaryCategories { get; set; }
        public DbSet<ThirdCategory> ThirdCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Suggestion> Suggestions { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<ExpertSkill> ExpertSkills { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ExpertSkillConfiguration).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
