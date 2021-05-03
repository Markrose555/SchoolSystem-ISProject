using SchoolSystem.Models.Models.Class;
using SchoolSystem.Models.Models.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.StudentClass
{
    public class StudentClassCreateModel
    {
        [Required]
        public int Student { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public int Grade { get; set; }
    }
}
