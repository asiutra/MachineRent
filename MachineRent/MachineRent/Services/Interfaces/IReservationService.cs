using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models;

namespace MachineRent.Services.Interfaces
{
    public interface IReservationService
    {
        Task<bool> AddReservationAsync(Reservations reservations);
        Task<bool> RemoveReservationAsync(int id);
        Task<bool> ExtendReservationAsync(int id);
    }
}
