using Microsoft.AspNetCore.Mvc;
using Practical_Test2.Models;

namespace Practical_Test2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.AllStudents);
        }
        public IActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStudent(Student mystudent)
        {
            Repository.Create(mystudent);
            return View("AddedSuccessfully");
        }
    }
}
