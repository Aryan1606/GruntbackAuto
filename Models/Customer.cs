﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace GruntbackAuto.Models
{
    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }

    public class Customer
    {
        public string Name { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
        public Address Address { get; set; }
    }
}