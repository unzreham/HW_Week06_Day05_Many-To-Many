using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class InstructorModel
    {
        [Key]
        public int InstructorId { get; set; }

        [Column(TypeName = "varchar(200)")]
        public string InstructorName { get; set; }
        public List<Instructor_Student> Instructor_Students;

        // public ICollection<StudentModel> Students { get; set; }

    }
}

