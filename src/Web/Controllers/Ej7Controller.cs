using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej7Controller : ControllerBase
{
    [HttpGet]
    public IActionResult GetNumbers()
    {
        var numbers = new List<int>();
        int i = 1;
        while (i <= 100)
        {
            numbers.Add(i);
            i++;
        }
        return Ok(numbers);
    }

}