using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Context;
using MachineRent.Models;
using MachineRent.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MachineRent.Services
{
    public class MachinesService : IMachinesService
    {
        private readonly MachineRentContext _context;

        public MachinesService(MachineRentContext context)
        {
            this._context = context;
        }

        public async Task<bool> CreateAsync(Machines machines)
        {
            await _context.Machines.AddAsync(machines);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Machines> GetAsync(int id)
        {
            return await _context.Machines.SingleOrDefaultAsync(x => x.MachineId == id);
        }

        public async Task<IList<Machines>> GetAllAsync()
        {
            return await _context.Machines.OrderBy(machines => machines.Brand).ToListAsync();
        }
        

        public async Task<bool> UpdateAsync(Machines machines)
        {
            _context.Machines.Update(machines);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var machine = await _context.Machines.SingleOrDefaultAsync(x => x.MachineId == id);
            if (machine == null)
                return false;
            _context.Machines.Remove(machine);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
