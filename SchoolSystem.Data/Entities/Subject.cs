using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Data.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
