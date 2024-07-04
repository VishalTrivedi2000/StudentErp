using Microsoft.AspNetCore.Mvc;

namespace AMNEVH.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentDashboard()
        {
            return View();
        }
    }
}
