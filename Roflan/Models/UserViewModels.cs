using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Roflan.Areas.Administration.Models;

namespace Roflan.Models
{
    public class RegisterViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int UserId { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Required Field")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Required Field")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Reqired Field")]
        public string Email { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Required Field")]
        [System.ComponentModel.DataAnnotations.Compare(nameof(NewPassword), ErrorMessage = "Passwords don't match.")]
        public string Password { get; set; }
        [MinLength(5)]
        [Required(ErrorMessage = "Required Field")]
        [HiddenInput(DisplayValue = false)]
        public string NewPassword { get; set; }
        
        [Display(Name = "Status")]
        public string RoleName { get; set; }
    }
    public class RegisterListViewModel
    {
        public List<RegisterViewModel> RegisterList { get; set; }
        public PageInfo PageInfo { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Empty Field")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Empty Field")]
        public string Password { get; set; }
    }
    public class EditModel
    {
        [MinLength(5)]
        public string FirstName { get; set; }
        [MinLength(5)]
        public string LastName { get; set; }
        [MinLength(5)]
        public string Password { get; set; }
    }
}