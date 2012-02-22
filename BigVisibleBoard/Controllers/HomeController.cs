using System.Web.Mvc;

namespace BigVisibleBoard.Controllers
{
    public class HomeController : Controller
    {
         public ViewResult Index()
         {
             return View();
         }
    }
}