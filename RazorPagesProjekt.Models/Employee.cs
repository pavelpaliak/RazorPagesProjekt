using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorPagesProjekt.Models
{
	public class Employee
	{
		public int Id { get; set; }
		[Required(ErrorMessage ="The name field cannot be null! Please, write the name")]
		[MaxLength(50), MinLength(2)]
		public string Name { get; set; }
		[Required]
		[RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Please, enter a Valid Email (format: example@exem.com)")]
		[MaxLength(50), MinLength(2)]
		public string Email { get; set; }
		public string? PhotoPath { get; set; }
		public Dept? Department { get; set; }

	}
}
