using Eurotherm.PatientManagement.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Eurotherm.PatientManagement.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View(SharedPatients.Instance
                                            .OrderBy(p => p.Surname));
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Patient newPatient)
        {
            if (!ViewData.ModelState.IsValid)
            {
                return Create();
            }

            if (!SharedPatients.Instance.Create(newPatient))
            {
                ViewData.ModelState.AddModelError("Duplicate", "A Patient already exists with the same Name and Birth date");
                return Create();
            }

            return RedirectToAction("Index");
        }
	}
}