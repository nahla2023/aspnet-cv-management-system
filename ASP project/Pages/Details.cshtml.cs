using ASP_project.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_project.Pages
{
    public class DetailsModel : PageModel
    {
        public readonly DBHelper _Context;
        public readonly CRUD _crud;
        public CV c { get; set; }
        public DetailsModel(DBHelper C,CRUD crud)
        {
            _Context = C;
            _crud = crud;
        }
        public void OnGet(int? id)
        {
            if (id != null)
            {
                c = _crud.Read(_Context, id);
            

            }
        }
    }
}
