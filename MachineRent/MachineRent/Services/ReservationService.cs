using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MachineRent.Context;
using MachineRent.Models;
using MachineRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace MachineRent.Services
{
    public class ReservationService : IReservationService
    {
        private readonly MachineRentContext _context;
        protected UserManager<IdentityUser> userManager;

        public ReservationService(MachineRentContext context, UserManager<IdentityUser> userManager)
        {
            this._context = context;
            this.userManager = userManager;
        }

        public async Task<bool> AddReservationAsync(Reservations reservations)
        {
            //var user = new IdentityUser();
            //user.Id = userManager.GetUserId(ClaimsPrincipal.Current);

            //var reserv = new Reservations()
            //{
            //    RentFromDate = reservations.RentFromDate,
            //    RentToDate = reservations.RentToDate,
            //    MachineId = machineId,
            //};

            await _context.Reservations.AddAsync(reservations);
            return await _context.SaveChangesAsync() > 0;

        }

        public Task<bool> RemoveReservationAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExtendReservationAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
