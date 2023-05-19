using System;
using System.ComponentModel.DataAnnotations;

namespace hol.visitor.Models
{
	public class UserSignInViewModel
	{
		[Required(ErrorMessage ="Please Enter Username")]
		public string? username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string? password { get; set; }
    }
}

