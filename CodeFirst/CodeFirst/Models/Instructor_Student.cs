using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Instructor_Student
    {
        [Key]
        public int Instructor_StudentModelid;
        public int InstructorId { get; set; }
        public InstructorModel Instructor { get; set; }

        public string StudentId { get; set; }
        public StudentModel Student { get; set; }
        public List<Instructor_Student> Instructor_Students;

    }
}
