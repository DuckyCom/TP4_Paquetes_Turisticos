using Microsoft.AspNetCore.Mvc;

namespace TP4_Paquetes_Turisticos.Controllers;
using TP4_Paquetes_Turisticos.Models;
public class HomeController : Controller
{
    public IActionResult Index()
    {            
        ViewBag.paquete = ORTWorld.Paquetes;
        return View();
    }
    public IActionResult SelectPaquete()
    {            
        ViewBag.destinos = ORTWorld.ListaDestinos;
        ViewBag.hoteles = ORTWorld.ListaHoteles;
        ViewBag.aereos = ORTWorld.ListaAereos;
        ViewBag.excursiones = ORTWorld.ListaExcursiones;
        return View();
    }
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {            
        Paquete nuevoPaquete = new Paquete();
        return View();
    }
    //ESTE ES EL UNICO CONTROLLER, CUALQUIER COSA DE CONTROLLER VA ACA Y NO SE CAMBIA
}
