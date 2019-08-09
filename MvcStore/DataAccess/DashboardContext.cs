using MvcStore.DataAccess.Configurations;
using MvcStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MvcStore.DataAccess
{
    public class DashboardContext : DbContext
    {
        public DashboardContext() : base("StoreOrder")
        {

        }

        public IDbSet<Customer> CustomerSet { get; set; }
        public IDbSet<Order> OrderSet { get; set; }
        public IDbSet<Product> ProductSet { get; set; }
        public IDbSet<OrderDetails> OrderDetailSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
            modelBuilder.Configurations.Add(new OrderConfiguration());
            modelBuilder.Configurations.Add(new ProductConfiguration());
            modelBuilder.Configurations.Add(new OrderDetailsConfiguration());
        }
    }
}