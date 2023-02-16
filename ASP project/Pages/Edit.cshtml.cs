using ASP_project.DB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;

namespace ASP_project.Pages
{
    public class EditModel : PageModel
	{
		public readonly DBHelper _Context;
        private readonly Services _S;
        private readonly CRUD _crud;
        [Obsolete]
        private IHostingEnvironment _environment;
        [BindProperty(SupportsGet =true)]
        public CV c { get; set; }

        public string check1 = "Female";
        public string check2 = "Male";
        

        [BindProperty]
        public EditCVModel ECV { set; get; }


        [Obsolete]
        public EditModel(DBHelper C,Services s, IHostingEnvironment environment,CRUD crud)
		{
            _Context = C;
            _S = s;
            _environment = environment;
            _crud = crud;
        }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                c = _crud.Read(_Context, id);
                
            }
        }

        [Obsolete]
        public ActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
         
            if (ECV.AreChecked != null)
            {
                ECV.Skills = _S.concatenate(ECV.AreChecked);
            }

            else
            {
                return Page();

            }

            var file = Path.Combine(_environment.ContentRootPath, "wwwroot/photos", ECV.Image.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                ECV.Image.CopyToAsync(fileStream);
            }
            ECV.img = ECV.Image.FileName;
           

            _crud.update(id,_Context,c.firstname,c.lastname,c.Email,c.Gender,c.Nationality,c.DateOfBirth.ToString(), ECV.Skills.Replace("I", " "), c.grade, ECV.img);
            return RedirectToPage("Browse CVs");
        }
    }
}
