using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models;

namespace MachineRent.Services.Interfaces
{
    interface IMachinesService
    {
        Task<bool> CreateAsync(Machines machines);
        Task<Machines> GetAsync(int id);
        Task<IList<Machines>> GetAllAsync();

        Task<bool> UpdateAsync(Machines machines);
        Task<bool> DeleteAsync(int id);
    }
}
