﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models;
using MachineRent.Models.ViewModels;

namespace MachineRent.Services.Interfaces
{
    public interface IMachinesService
    {
        Task<bool> CreateAsync(Machines machines);
        Task<Machines> GetAsync(int id);
        Task<IList<Machines>> GetAllAsync();

        Task<bool> UpdateAsync(Machines machines);
        Task<bool> DeleteAsync(int id);

        Task<IList<Machines>> GetAllForUser();
    }
}
