namespace TP4_Paquetes_Turisticos.Models;

public class ORTWorld
{
    public static List<string> ListaDestinos {get; private set;} = new List<string>
    {
        "buenos aires", 
        "paris", 
        "barcelona",  
        "ottawa",  
        "florida"/*🦅🦅🦅*/,  
        "varsovia",  
        "vilna",  
        "dakar",  
        "grieta del invocador",  
        "runaterra"
    };
    public static List<string> ListaHoteles {get; private set;} = new List<string>
    {
        "trivago", "santa maria", "babilonia", "el one piece", "cherniak", "momazos", "grasa", "notengoideadequeponer", "goku", "kratos" 
    };
    public static List<string> ListaAereos {get; private set;} = new List<string>
    {
        "elver galarga", 
        "binker", 
        "iberia", 
        "poppy"/*Aerolineas Martillo*/, 
        "maradona", 
        "aerolineas argentinas", 
        "readme.md", 
        "aereo", 
        "aprobanosporfa", 
        "india", 
    };
    public static List<string> ListaExcursiones {get; private set;} = new List<string>
    {
        "esqui", "entrenamiento", "calistenia", "tirolesa", "tracking", "silent-fest", "rafting", "canopy", "tutorial-Csharp", "tutorial-pseint", 
    };
    public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete) 
    {
        bool retorno = true;
        foreach (string item in ORTWorld.Paquetes.Keys) {
            if(item == destinoSeleccionado) 
                retorno = false;
        }
        
        if(retorno) 
            Paquetes.Add(destinoSeleccionado, paquete);

        return retorno;
    }
   public static void DeletePaquete(string destino){
        foreach (string item in ORTWorld.Paquetes.Keys)
        {
            if (item == destino) 
                ORTWorld.Paquetes.Remove(item);
        }
    }
}