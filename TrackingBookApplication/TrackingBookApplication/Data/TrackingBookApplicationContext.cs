using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackingBookApplication.Models;

namespace TrackingBookApplication.Data
{
    public class TrackingBookApplicationContext : DbContext
    {
        public TrackingBookApplicationContext (DbContextOptions<TrackingBookApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<TrackingBookApplication.Models.Book> Book { get; set; } = default!;

        public DbSet<TrackingBookApplication.Models.Category>? Category { get; set; }
    }
}
