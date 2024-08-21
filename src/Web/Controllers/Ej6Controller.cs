using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class Ej6Controller : ControllerBase
{
    [HttpGet]
    public IActionResult GetNumbers()
    {
        var numbers = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            numbers.Add(i);
        }
        return Ok(numbers);
    }

}