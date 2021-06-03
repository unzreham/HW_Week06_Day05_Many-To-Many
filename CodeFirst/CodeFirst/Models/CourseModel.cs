using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseId { get; set; }
        [Column(TypeName = "varchar(300)")]
        public string CourseName { get; set; }

    }
}
