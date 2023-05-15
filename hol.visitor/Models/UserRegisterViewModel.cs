using System;
using System.ComponentModel.DataAnnotations;

namespace hol.visitor.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Please enter name")]
		public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter Surname")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Please enter Username")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter Mail")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "Please enter Password")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please enter try Password")]
        public string? ConfirmPassword { get; set; }
    }
}

