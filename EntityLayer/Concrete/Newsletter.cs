using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
	public class Newsletter
	{
        [Key]
        public int NewsLetterID { get; set; }

		public string? Mail { get; set; }
	}
}

