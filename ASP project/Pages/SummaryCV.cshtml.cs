using ASP_project.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PdfSharp.Pdf;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace ASP_project.Pages
{
    public class SummaryCVModel : PageModel
    {
        [BindProperty]
        public  InputModel SV { get; set; }
        
        public void OnGet()
        {
          

        }
        public void OnPost()
        {
            
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string htmlString = "<h1>" + SV.FirstName +" "+ SV.LastName + "</h1><hr><h3>Email:</h3><p><i>" + SV.Email + "</i></p></br><h3>Gender:</h3></br><p>"+SV.Gender+
                "</p><h3>Date Of Birth:</h3></br>"+SV.date + "</p><h3>Nationality:</h3></br><p>"+SV.Nationality + "</p><h3>Skills:</h3></br><p>"+SV.Skills.Replace("I", " ") + "</p><h3>Photo:</h3></br>"+  "<img src = " + "C:/Users/Nahla Abu Shakra/source/repos/ASP Project/ASP project/wwwroot/photos/"+SV.img+ "\"  alt = " + "Photo " + "style = " + "width: 50%; height:50% " + " > ";
           
            PdfDocument pdfdocument = PdfGenerator.GeneratePdf(htmlString, PdfSharp.PageSize.A4);
            pdfdocument.Save("CV.pdf");

        }
       
    }
}
