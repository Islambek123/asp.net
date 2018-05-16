using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roflan.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Required Field")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required Field")]
        public string LastName { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage ="Reqired Field")]
        public string Email { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Required Field")]
        [Compare(nameof(NewPassword), ErrorMessage = "Passwords don't match.")]
        public string Password { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Required Field")]
        public string NewPassword { get; set; }
    }
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Empty Field")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Empty Field")]
        public string Password { get; set; }
    }
}