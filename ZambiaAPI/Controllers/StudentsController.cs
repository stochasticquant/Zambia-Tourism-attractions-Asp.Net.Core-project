using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ZambiaAPI.Controllers
{
    // https://localhost:portnumber/api/students : This is the URL that will be used to access the controller.
    // it uses the name of the controller to create the URL.
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private string[] studentsNames = new string[]
        {
            "John Doe",
            "Jane Doe",
            "James Doe",
            "Janet Doe"
            };

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            // Ok means return a 200 status code with the studentsNames array.
            return Ok(studentsNames);
        }
    }
}
