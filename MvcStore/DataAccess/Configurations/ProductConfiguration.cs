﻿using MvcStore.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcStore.DataAccess.Configurations
{
    public class ProductConfiguration : EntityConfiguration<Product>
    {
        public ProductConfiguration()
        {
            Property(p => p.ProductName).IsRequired().HasMaxLength(100);
            Property(p => p.UnitPrice).IsRequired();
            Property(p => p.ProductImage).IsRequired().HasMaxLength(100);
            Property(p => p.UnitsInStock).IsRequired();
        }
    }
}