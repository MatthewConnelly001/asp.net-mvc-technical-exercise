using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Bookstore.Controllers
{
    public class BookstoreController : Controller
    {
        /*
        public IActionResult Index()
        {
            return View();
        }
        */
        //
        // GET: /Bookstore/
        public string Index()
        {
            return "Bookstore index page...";
        }
        //
        // GET: /Bookstore/Welcome/
        // Requires using System.Text.Encodings.Web;
        // Uses 'name' as a URL query parameter.
        public string Welcome(string name)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}. This is the Bookstore welcome page.");
        }

    }
}


