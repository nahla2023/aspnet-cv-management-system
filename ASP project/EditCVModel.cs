using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP_project
{
    public class EditCVModel
    {
      
        public string Skills { get; set; }

        [Required]
        [Display(Name = "Programming Skills")]
        public List<string> AreChecked { get; set; }

        [Required]
        public IFormFile Image { set; get; }

        public string img { set; get; }
    }
}
