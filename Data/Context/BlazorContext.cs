using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    internal class BlazorContext : DbContext
    {

        public BlazorContext(DbContextOptions<BlazorContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var entitiesAssembly = typeof(IEntity).Assembly;

            //modelBuilder.RegisterAllEntities<IEntity>(entitiesAssembly);
            //modelBuilder.RegisterEntityTypeConfiguration(entitiesAssembly);
            //modelBuilder.SetQueryFilterConfiguration();
            //modelBuilder.AddRestrictDeleteBehaviorConvention();
            //modelBuilder.AddSequentialGuidForIdConvention();
            //modelBuilder.AddPluralizingTableNameConvention();
            //modelBuilder.RegisterAllEnum();

            //var assembly = typeof(PermissionSeeder).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);


            base.OnModelCreating(modelBuilder);
        }
    }
}
