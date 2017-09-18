using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RegistrationApp4.Controllers
{
    public class StudentController : Controller
    {
        // 
        // GET: /Student/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Student/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}