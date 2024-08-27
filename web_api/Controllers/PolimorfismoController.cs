using Microsoft.AspNetCore.Mvc;
using web_api.animal;
using web_api.dto.common;
using web_api.dto.login;
using web_api.helpers;
using web_api.mock;

namespace web_api.Controllers;


[ApiController]
[Route("[controller]")]
public class PolimorfismoController : ControllerBase
{
    private readonly ILogger<PolimorfismoController> _logger;
    
    public PolimorfismoController(ILogger<PolimorfismoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Hablar")]
    public IActionResult Get()
    {
        List<IMascota> animales = obtenerAnimales(); //Podría ser de la BD.

        List<object> list = new List<object>();

        foreach(IMascota animal in animales)
        {
            list.Add(new
            {
                //hablar = animal.Hablar(),
                //IMascotacomer = animal.Comer(),
                Acariciar = animal.Acariciar()
            });
        }

        return Ok(list);
    }

    private List<IMascota> obtenerAnimales()
    {
        List<IMascota> animals = new List<IMascota>();
        
        for(int i = 0; i < 5; i++)
        {
            int numero = Random.Shared.Next(1, 3);
            if(numero == 1)
            {
                animals.Add(new Perro());
            }
            else
            {
                animals.Add(new Gato());
            }
        }

        return animals;
    }
}