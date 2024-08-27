namespace web_api.animal;

public class Gato : IAnimal, IMascota
{
    public string Comer()
    {
        return "Gati";
    }

    public string Hablar()
    {
        return "Miau";
    }

    public string Acariciar()
    {
        return "Ronroneo";
    }
}