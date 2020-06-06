using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MachineRent.Models.ViewModels;
using MachineRent.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MachineRent.Controllers
{
    public class MachineController : Controller
    {
        private readonly IMachinesService _machinesService;

        public MachineController(IMachinesService machinesService)
        {
            this._machinesService = machinesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var machines = await _machinesService.GetAllAsync();

            return View(machines);
        }
    }
}