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
        bool error = false;
        if(Destino == null || Hotel == null || Aereo == null || Excursion == null) error = true;
        if(!error)
        {
            Paquete nuevoPaquete = new Paquete(ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino], nuevoPaquete);
        }
        ViewBag.Error = error;
        return View("Index");
    }
    //ESTE ES EL UNICO CONTROLLER, CUALQUIER COSA DE CONTROLLER VA ACA Y NO SE CAMBIA
}
