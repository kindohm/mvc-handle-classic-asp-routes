using System.Dynamic;
using System.Web.Mvc;

namespace ClassicAspFileRoutes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Results(string theInput)
        {
            dynamic viewModel = new ExpandoObject();
            viewModel.TheInput = string.IsNullOrEmpty(theInput) ? "NOTHING" : theInput;
            return View(viewModel);
        }
    }
}