using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models;
using MachineRent.Models.ViewModels;
using MachineRent.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MachineRent.Controllers
{
    public class MachineController : Controller
    {
        private readonly IMachinesService _machinesService;
        private readonly IReservationService _reservationService;
        private UserManager<IdentityUser> _userManager;

        public MachineController(IMachinesService machinesService, IReservationService reservationService, UserManager<IdentityUser> userManager)
        {
            this._machinesService = machinesService;
            this._reservationService = reservationService;
            this._userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Machines model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var result = await _machinesService.CreateAsync(model);
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var machines = await _machinesService.GetAllAsync();

            return View(machines);
        }

        [HttpGet]
        public async Task<IActionResult> FormReservation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> FormReservation(Reservations model, int id)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.GetUserAsync(User);

            if (user == null)
            {
                ModelState.AddModelError("", "Błąd dodawania rezerwacji.");
                return View(model);
            }

            var reservation = new Reservations()
            {
                RentFromDate = model.RentFromDate,
                RentToDate = model.RentToDate,
                MachineId = id,
                User = user
            };

            var result = await _reservationService.AddReservationAsync(reservation);
            
            //TODO: 
            return RedirectToAction("Index", "Home");
        }
    }
}