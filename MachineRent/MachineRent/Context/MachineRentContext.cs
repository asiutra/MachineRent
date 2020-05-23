using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MachineRent.Context
{
    public class MachineRentContext : IdentityDbContext
    {
        public MachineRentContext(DbContextOptions options) : base(options)
        {

        }
    }
}
