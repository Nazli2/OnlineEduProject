using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineEdu.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        [AllowAnonymous]
        public IActionResult NotFound404()
        {
            return View();
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
