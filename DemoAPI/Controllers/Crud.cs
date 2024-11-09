using DemoAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPi.Contollers
{
    [ApiController]
    [Route("api/{Controller}")]
    public class CrudController:Controller
    {
        List<Student> students=new List<Student>()
        {
            new Student{Id=101,Name="Suruli",Age=21,Gender="Male"},
            new Student{Id=102,Name="Ganesh",Age=44,Gender="Male"},
            new Student{Id=103,Name="Tappas",Age=20,Gender="Male"},
            new Student{Id=104,Name="Kavitha",Age=21,Gender="Female"},
            new Student{Id=105,Name="Karamadai Ranganathan",Age=45,Gender="Male"}
        };

        [HttpGet("GetAllStudents")]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return Ok(students.ToList());
        }
    }
}

