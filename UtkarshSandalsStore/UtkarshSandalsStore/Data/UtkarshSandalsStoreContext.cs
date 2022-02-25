using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UtkarshSandalsStore.Models;

namespace UtkarshSandalsStore.Data
{
    public class UtkarshSandalsStoreContext : DbContext
    {
        public UtkarshSandalsStoreContext (DbContextOptions<UtkarshSandalsStoreContext> options)
            : base(options)
        {
        }

        public DbSet<UtkarshSandalsStore.Models.Sandal> Sandal { get; set; }
    }
}
