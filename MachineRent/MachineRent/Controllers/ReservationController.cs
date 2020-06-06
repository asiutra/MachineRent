using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models;
using MachineRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MachineRent.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IMachinesService _machinesService;
        private readonly IReservationService _reservationService;
        private UserManager<IdentityUser> _userManager;

        public ReservationController(IMachinesService machinesService, IReservationService reservationService, UserManager<IdentityUser> userManager)
        {
            this._machinesService = machinesService;
            this._reservationService = reservationService;
            this._userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> MyReservation()
        {
            var myMachines = await _machinesService.GetAllForUser();
            return View(myMachines);
        }
    }
}