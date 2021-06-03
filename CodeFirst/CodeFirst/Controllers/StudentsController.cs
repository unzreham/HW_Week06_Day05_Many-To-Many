using CodeFirst.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDbContext _db;

        public StudentsController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
           var Students = _db.Student.ToList();
            ViewData["Students"] = Students;


            //var id =_db.Student.FirstOrDefault(a => a.studentId == 1).studentId;

            // var id = -_db.Student.SingleOrDefault(a => a.studentId == 5).studentId;
            var id = _db.Student.Where(a => a.studentId > 5).ToList();
            ViewData["studentId"] = id;
            return View();
        }


        public IActionResult details( int id )
        {
            // var id =_db.Student.FirstOrDefault(a => a.studentId == _id).studentId;
            var student = _db.Student.ToList().Find(a => a.studentId == id);
            ViewData["student"] = student;
            return View();
        }


        public IActionResult search(string txt = "")
        {
           // var listOfStudent = _db.Student.ToList();
            // ViewData["listOfStudent"] = listOfStudent;
          //  var id = _db.Student.Where(a => a.studentId > 5).ToList();
          var aa = _db.Student.Where(a => a.studentName.Contains(txt));
            ViewData["listOfStudent"] = aa;
            return View("Index");
        }
    }
}
