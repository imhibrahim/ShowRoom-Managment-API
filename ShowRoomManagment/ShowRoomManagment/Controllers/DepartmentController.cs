using Microsoft.AspNetCore.Mvc;

namespace ShowRoomManagment.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
