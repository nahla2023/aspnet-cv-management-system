using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_project
{
    public class InputModel
    {
        [Required]
        [Display(Name = "Your name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]

        public string Nationality { get; set; } = " ";

        [Required]
        public string Gender { get; set; }
        public int grade { get; set; }
        public string Skills { get; set; }

        [Required]
        [Display(Name = "Programming Skills")]
        public List<string> AreChecked { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "Confirm Email")]
        [Compare("Email", ErrorMessage = "*Error")]
        public string Confirm_email { get; set; }


        [Required]
        public int sum { get; set; }

        [Required]
        [Range(1, 21)]
        public int x { get; set; }


        [Required]
        [Range(20, 51)]
        public int y { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string date { get; set; }

        [Required]
        public IFormFile Image { set; get; }

        public string img { set; get; }
    }
}
