using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Comp229PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please choose a selection")]
        public bool? WillAttend { get; set; }

    }
}
