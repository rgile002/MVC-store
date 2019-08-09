using MvcStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStore.DataAccess.Configurations
{
    public class OrderConfiguration : EntityConfiguration<Order>
    {
        public OrderConfiguration()
        {
            Property(o => o.OrderDate).IsRequired();
        }
    }
}