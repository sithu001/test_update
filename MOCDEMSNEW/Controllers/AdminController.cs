using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MOCDEMSNEW.Controllers
{
    
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
