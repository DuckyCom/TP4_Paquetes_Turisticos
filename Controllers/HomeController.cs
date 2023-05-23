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
        Destino--;
        Hotel--;//Ponemos los -- porque sino al poner 1 se pone en 2 y al 10 en 11 [tira error]
        Aereo--;//antes funcionaba, a menos que ambos en el trabajo estemos locos y hayamos pensado que funcionaba
        Excursion--;
        bool error = false;
        if(Destino == null || Hotel == null || Aereo == null || Excursion == null) 
            error = true;
        if(!error)
        {
            Paquete nuevoPaquete = new Paquete(ORTWorld.ListaHoteles[Hotel], ORTWorld.ListaAereos[Aereo], ORTWorld.ListaExcursiones[Excursion]);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino], nuevoPaquete);
            return RedirectToAction("Index");
        }
        else
        {
            return View("SelectPaquete");
        }
        
    }

    public IActionResult DeletePaquete(string destino)
    {
        ViewBag.paquete = ORTWorld.Paquetes;
        if (destino == null)
        {
            return View("DeletePaquete");
        }
        else
        {
            ORTWorld.DeletePaquete(destino);
            return RedirectToAction("Index");
        } 
    }
    //ESTE ES EL UNICO CONTROLLER, CUALQUIER COSA DE CONTROLLER VA ACA Y NO SE CAMBIA
}
