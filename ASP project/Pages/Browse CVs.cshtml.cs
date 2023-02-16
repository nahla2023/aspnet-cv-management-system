using ASP_project.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ASP_project.Pages
{
    public class Browse_CVsModel : PageModel
    {
        public readonly CRUD _crud;
        public readonly DBHelper _Context;
        public CV c { get; set; }
        public Browse_CVsModel(DBHelper C ,CRUD crud)
        {
            _Context = C;
            _crud = crud;
        }
        public void OnGet()
        {
           
        }
        public ActionResult OnGetDelete(int id)
        {
            
           
            _crud.Delete(id,_Context);
            
        
            return Redirect("Browse CVs"); 
        }
    }
}
