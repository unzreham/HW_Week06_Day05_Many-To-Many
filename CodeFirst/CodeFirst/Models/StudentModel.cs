using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class StudentModel
    {
        [Key]
        public int studentId { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string studentName { get; set; }


        public List<Instructor_Student> Instructor_Students;
     //   public ICollection<InstructorModel> Instructors { get; set; }

    }
}
