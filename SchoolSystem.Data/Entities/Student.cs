using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public DateTime StudentDoB { get; set; }
        public int StudentYear { get; set; }
        public virtual ICollection<StudentSubject> StudentSubjects { get; set; }
    }
}
