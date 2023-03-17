using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext _context;
    public EventoController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]

    public IEnumerable<Models.Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]

    public IEnumerable<Models.Evento> GetById(int id)
    {
        return _context.Eventos.Where(evento => evento.EventoId == id);
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
