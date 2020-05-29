using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MachineRent.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Pole wymagane")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Pole wymagane"), EmailAddress(ErrorMessage = "Niepoprawny adres email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Pole wymagane")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Pole wymagane"), Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
