using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace RegistrationApp4.Controllers
{
    public class RegistrarController : Controller
    {
        // 
        // GET: /Registrar/

        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /Registrar/Welcome/ 

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}