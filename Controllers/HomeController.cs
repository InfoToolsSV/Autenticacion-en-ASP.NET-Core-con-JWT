using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AuthJWT.Controllers;

public class HomeController : Controller
{

    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
    [AllowAnonymous]
    public IActionResult Privacy()
    {
        return View();
    }

}
