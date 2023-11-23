using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    private static readonly string[] names = new[]
    {
        "hung","hung2","hunng1"
    };

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Student
            {
                Id = Random.Shared.Next(1,20),
                Name = names[Random.Shared.Next(names.Length)],
                Age = Random.Shared.Next(10,40)
            })
            .ToArray();
    }
    
}
