using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNet_Lab4.Models;

namespace DotNet_Lab4.Data
{
    public class DotNet_Lab4Context : DbContext
    {
        public DotNet_Lab4Context (DbContextOptions<DotNet_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<DotNet_Lab4.Models.Customer> Customer { get; set; } = default!;

        public DbSet<DotNet_Lab4.Models.Payment>? Payment { get; set; }

        public DbSet<DotNet_Lab4.Models.Orders>? Orders { get; set; }
    }
}
