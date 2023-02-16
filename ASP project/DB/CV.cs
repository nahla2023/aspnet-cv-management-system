using System.ComponentModel.DataAnnotations;

namespace ASP_project.DB
{
	public class CV
	{

		public int id {get; set; }
        [Required]
        [Display(Name="First Name")]
		public string firstname {get; set; }
		[Required]
		[Display(Name = "last Name")]
		public string lastname {get; set; }
        [Required]
        [EmailAddress]
		public string Email {get; set; }
        [Required]
		public string Gender {get; set; }

        [Required]
		[Display(Name = "Date Of Birth")]
		public string DateOfBirth { get; set; }

		[Required]
		public string Nationality {get; set; }

		[Required]
		public int grade { get; set; }
		public string Skills { get; set; }

		public string photo { get; set; }
	}
}
