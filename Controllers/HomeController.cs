using Microsoft.AspNetCore.Mvc;

namespace TP4_Paquetes_Turisticos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
