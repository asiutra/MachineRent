using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MachineRent.Models
{
    public class Reservations
    {
        [Key]
        public int ReservationId { get; set; }
        [Required]
        public DateTime RentFromDate { get; set; }
        [Required]
        public DateTime RentToDate { get; set; }
        public int MachineId { get; set; }
        [ForeignKey("MachineId")]
        public Machines Machines { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}
