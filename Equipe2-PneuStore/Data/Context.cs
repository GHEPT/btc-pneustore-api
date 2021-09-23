using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Equipe2_PneuStore.Data
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base (options) { }
    }
}
