using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ILogger<EventoController> _logger;

    public IEnumerable<Models.Evento> _evento = new Models.Evento[]
        {
            new Models.Evento()
            {
            EventoId = 1, 
            Tema = "Angular 11 e .NET 5",
            Local = "Pres Prudente",
            Lote = "1° Lote", 
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString()
            },

            new Models.Evento()
            {
            EventoId = 2, 
            Tema = ".NET 8",
            Local = "Sao Paulo",
            Lote = "2° Lote", 
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "Foto.png"
            }
        };
    public EventoController()
    {

    }

    [HttpGet]

    public IEnumerable<Models.Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]

    public IEnumerable<Models.Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost(Name = "GetEvento")]
    public string  Post()
    {
        return "Exemplo de Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de Put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de Delete com id = {id}";
    }
}


