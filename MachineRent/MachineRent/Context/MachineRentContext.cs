using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MachineRent.Context
{
    public class MachineRentContext : IdentityDbContext
    {
        public MachineRentContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Machines> Machines { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
    }
}
