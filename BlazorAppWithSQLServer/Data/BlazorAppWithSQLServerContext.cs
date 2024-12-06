using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppWithSQLServer.Models;

namespace BlazorAppWithSQLServer.Data
{
    public class BlazorAppWithSQLServerContext : DbContext
    {
        public BlazorAppWithSQLServerContext (DbContextOptions<BlazorAppWithSQLServerContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppWithSQLServer.Models.Employees> Employees { get; set; } = default!;
    }
}
