using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roflan.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 255), Display(Name = "First Name")]

        public string FirstName { get; set; }
        [Required, StringLength(maximumLength: 255), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Password { get; set; }
        [Required, StringLength(maximumLength: 255)]
        public string Email { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
    }
}