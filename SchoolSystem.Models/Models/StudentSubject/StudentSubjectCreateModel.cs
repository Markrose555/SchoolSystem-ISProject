using SchoolSystem.Models.Models.Subject;
using SchoolSystem.Models.Models.Student;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.StudentSubject
{
    public class StudentSubjectCreateModel
    {
        [Required]
        public int StudentId { get; set; }
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public int Grade { get; set; }
    }
}
