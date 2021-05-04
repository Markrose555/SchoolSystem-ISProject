using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.StudentSubject
{
    public class StudentSubjectUpdateModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int Student { get; set; }
        [Required]
        public int Subject { get; set; }
        [Required]
        public int Grade { get; set; }
    }
}
