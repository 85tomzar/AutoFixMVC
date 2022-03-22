using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class AutoFixContext : DbContext
    {
        public AutoFixContext (DbContextOptions<AutoFixContext> options)
            : base(options)
        {
        }

        public DbSet<AutoFix.Models.Booking> Booking { get; set; }
    }
