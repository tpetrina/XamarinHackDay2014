using System.Web.Mvc;
using GeoChat.Models;
using GeoChat.Persistance;

namespace GeoChat.Services.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}