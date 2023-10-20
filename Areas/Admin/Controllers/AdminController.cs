using System.Numerics;
using Microsoft.AspNetCore.Mvc;
namespace TaskOrder.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}