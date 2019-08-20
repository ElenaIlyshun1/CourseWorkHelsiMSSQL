using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkHelsiMSSQL.Entities
{
    
        [Table("tblDoctors")]
        public class Doctor
        {
            [Key, Column(Order = 0)]
            public int Id { get; set; }
            [Required, StringLength(maximumLength: 250)]
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Spetialization { get; set; }

            public DateTime DateBirthday { get; set; }
        }
    
}
