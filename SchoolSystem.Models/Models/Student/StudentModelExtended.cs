using SchoolSystem.Models.Models.StudentClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.Student
{
    public class StudentModelExtended
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DoB { get; set; }
        [Required]
        public int Year { get; set; }
        public virtual ICollection<StudentClassModel> StudentClasses { get; set; }
    }
}
