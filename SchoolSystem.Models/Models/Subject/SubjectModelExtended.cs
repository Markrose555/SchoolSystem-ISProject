using SchoolSystem.Models.Models.StudentSubject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Models.Subject
{
    public class SubjectModelExtended
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public IEnumerable<StudentSubjectModel> StudentSubjects { get; set; }
    }
}
