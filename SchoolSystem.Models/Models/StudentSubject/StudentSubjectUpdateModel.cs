using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.StudentClass
{
    public class StudentSubjectUpdateModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Student { get; set; }
        [Required]
        public int Class { get; set; }
        [Required]
        public int Grade { get; set; }
    }
}
