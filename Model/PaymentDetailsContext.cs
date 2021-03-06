﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace CoreApiPayment.Model
{
    public class PaymentDetailsContext : DbContext
    {
        public PaymentDetailsContext(DbContextOptions<PaymentDetailsContext> options)
        : base(options)
        { }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
