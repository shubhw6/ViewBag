using Microsoft.AspNetCore.Mvc;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StudentId = 1;
            ViewBag.Name = "Shubh Verma";
            ViewBag.Age = 25;

            ViewBag .NameList= new List<string> { "Akash", "Amit", "Ayush" };

            Student student = new Student()
            {
                Id = 1,
                Name="Akasha",
                Description="Developer",
                StudentId=201
            };    

            ViewBag.StudentList=student;



            List<Student> studentsList= new List<Student>() { 
            
                new Student() {Id=1,Name="Legend",Description="Travel Company",StudentId=200},
                new Student() {Id=1,Name="Akasha",Description="Travel Company",StudentId=201},
                new Student() {Id=1,Name="OOO",Description="Travel Company",StudentId=202},
                new Student() {Id=1,Name="Yuya",Description="Travel Company",StudentId=203},


            };

            ViewBag.MyStudentList=studentsList;


            return View();
        }
    }
}
