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
    public IActionResult GuardarPaquete(string Destino, string Hotel, string Aereo, string Excursion)
    {
        bool error = true;
        if(Destino == null || Hotel == null || Aereo == null || Excursion == null) error = false;
        Paquete nuevoPaquete = new Paquete(Hotel, Aereo, Excursion);
        ORTWorld.Paquetes.Add(Destino, nuevoPaquete);
        ViewBag.Error = error;  
        return View();
    }
    //ESTE ES EL UNICO CONTROLLER, CUALQUIER COSA DE CONTROLLER VA ACA Y NO SE CAMBIA
}
