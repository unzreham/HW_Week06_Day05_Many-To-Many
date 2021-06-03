using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class RoomModel
    {
        [Key]
        public int roomId { get; set; }
        [MaxLength]
        /*        public string roomType { get; set; }
        */       // [Required]
        public bool Empty { get; set; }
        public int roomnUMBER { get; set; }




    }
}
