using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RegistrationApp4.Controllers
{
    public class CourseController : Controller
    {
        // 
        // GET: /Course/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Course/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}