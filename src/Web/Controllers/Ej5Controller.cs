using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej5Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get(string day)
    {
        if (string.IsNullOrWhiteSpace(day))
        {
            //error del cliente: ek dua bi fue proporcionado
            return BadRequest("El dia no puede estar vacio");

        }
        string lower = day.Trim().ToLower();
        if (lower == "domingo" || lower == "sàbado" || lower == "sabado")
        {
            return Ok("Es finde de semana");
        }
        else if (lower == "lunes" || lower == "martes" || lower == "miércoles" || lower == "miercoles" || lower == "jueves" || lower == "viernes")
        {
            return Ok("Es dia de semana");
        }
        else
        {
            return BadRequest("El dia proporcionado no es valido");
        }
    }
}
