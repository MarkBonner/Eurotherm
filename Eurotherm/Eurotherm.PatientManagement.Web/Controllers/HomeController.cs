using Eurotherm.PatientManagement.Web.Models;
using System.Web.Mvc;

namespace Eurotherm.PatientManagement.Web.Controllers
{
    public class HomeController : Controller
    {
        private static Patients _patients = new Patients();

        public ActionResult Index()
        {
            return View("");
        }

        public ActionResult About()
        {
            ViewBag.Message = "A Eurotherm sample application for managing patients.";

            return View();
        }
    }
}