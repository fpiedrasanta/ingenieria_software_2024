namespace web_api.animal;

public class Perro : IAnimal, IMascota
{
    public string Hablar()
    {
        return "Uau";
    }

    public string Comer()
    {
        return "Bacan";
    }

    public string Acariciar()
    {
        return "Muevo la cola";
    }
}