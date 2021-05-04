using SchoolSystem.Models.Models.Subject;
using SchoolSystem.Models.Models.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Models.StudentSubject
{
    public class StudentSubjectModel
    {
        public int Id { get; set; }
        public StudentModelBase Student { get; set; }
        public SubjectModelBase Subject { get; set; }
        public int Grade { get; set; }
    }
}
