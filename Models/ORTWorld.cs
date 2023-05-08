namespace TP4_Paquetes_Turisticos.Models;

public class ORTWorld
{
    public static List<string> ListaDestinos {get; private set;} = new List<string>();
    public static List<string> ListaHoteles {get; private set;}
    public static List<string> ListaAereos {get; private set;}
    public static List<string> ListaExcursiones {get; private set;}
    public static Dictionary<string, Paquete> Paquetes {get; private set;}

    public bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) 
    {
        bool retorno = false;
        return retorno;
    }
}