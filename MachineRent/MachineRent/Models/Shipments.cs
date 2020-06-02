using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRent.Models
{
    public class Shipments
    {
        [Key]
        public int ShipmentId { get; set; }
        [Required]
        public string Province { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string StreetNumber { get; set; }
        public int ReservationId { get; set; }
        [ForeignKey("ReservationId")]
        public Reservations Reservations { get; set; }
    }
}
