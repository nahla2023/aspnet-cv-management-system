using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Microsoft.AspNetCore.Hosting;
using ASP_project.DB;
using System.IO;



namespace ASP_project.Pages
{
	public class Send_CVModel : PageModel
    {
    
        public string[] Genders =  { "Male", "Female" };
        public string msg = "";
        public string msg2 = "";
        
        public string name;

        [BindProperty]
        public CV c {get; set;}
        public CRUD crud = new CRUD();
        private readonly Services _S;
        [Obsolete]
        private IHostingEnvironment _environment;

        [BindProperty]
        public InputModel Input { get; set; }

        private readonly DBHelper _Context;

        [Obsolete]
        public Send_CVModel(Services S,DBHelper C, IHostingEnvironment environment)
        {
            _S = S;
            _Context = C;
            _environment = environment;
        }
        public void OnGet()
        {
            

        }

        [Obsolete]
        public IActionResult OnPostSubmit()
        {
            var c1 = c;

            if (Input.AreChecked != null)
            {
                Input.Skills = _S.concatenate(Input.AreChecked); 
            }
           
            else
            {
                return Page();

            }
            if(Input.y<20 || Input.y > 50)
            {
                return Page();
            }

            if (Input.sum != _S.Sum(Input.x, Input.y))
            {
                msg = "Incorrect sum";
                return Page();

            }
            if(_S.validateEmail(Input.Email,Input.Confirm_email)== false)
            {
                msg2 = "Email and Confirmation Email must match.";
                return Page();
            }
       
              Input.grade = _S.grade(Input.AreChecked);


        
            var file = Path.Combine(_environment.ContentRootPath,"wwwroot/photos", Input.Image.FileName);
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                Input.Image.CopyToAsync(fileStream);
            }
            Input.img = Input.Image.FileName;
            c1.firstname =Input.FirstName;
            c1.lastname = Input.LastName;
            c1.Email = Input.Email;
            c1.Gender = Input.Gender;
            c1.DateOfBirth = Input.date.ToString();
            c1.Nationality = Input.Nationality;
            c1.grade = Input.grade;
            c1.Skills = Input.Skills.Replace("I", " ");
            c1.photo = Input.img;
            crud.create(c1,_Context);

            return Redirect("~/SummaryCV/" + Input.FirstName + "/" + Input.LastName + "/" + Input.Nationality + "/" + Input.grade + "/" + Input.Gender + "/" + Input.Skills + "/" + Input.Email + "/" + Input.sum + "/" + Input.date + "/" + Input.img);


        }

       



    }
    

}
