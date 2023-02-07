using Microsoft.AspNetCore.Mvc;
using MyFirstWebSite.Models;

namespace MyFirstWebSite.Controllers
{
    public class ContacsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(ContactsModel contact)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
