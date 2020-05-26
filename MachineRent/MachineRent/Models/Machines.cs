using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MachineRent.Models
{
    public class Machines
    {
        [Key]
        public int MachineId { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int HorsePower { get; set; }
        [Required]
        public int CostPerDay { get; set; }
        public ICollection<Reservations> Reservations { get; set; }

    }
}
