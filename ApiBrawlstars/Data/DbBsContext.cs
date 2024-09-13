using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiBrawlstars.Models;

namespace ApiBrawlstars.Data
{
    public class DbBsContext : DbContext
    {
        public DbBsContext (DbContextOptions<DbBsContext> options)
            : base(options)
        {
        }

        public DbSet<ApiBrawlstars.Models.Brawlstar> Brawlstar { get; set; } = default!;
    }
}
