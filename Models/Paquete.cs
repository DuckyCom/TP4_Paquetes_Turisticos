namespace TP4_Paquetes_Turisticos.Models;

public class Paquete
{
    public string Hotel {get; private set;}
    public string Aereo {get; private set;}
    public string Excursion {get; private set;}
    
    public Paquete(string hotel, string aereo, string excursion)
    {
        Hotel = hotel;
        Aereo = aereo;
        Excursion = excursion;
    }
    
}