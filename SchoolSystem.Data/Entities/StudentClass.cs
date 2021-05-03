using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SchoolSystem.Data.Entities
{
    public class StudentClass
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int Grade { get; set; }
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
        [ForeignKey("ClassId")]
        public Class Class { get; set; }
    }
}
