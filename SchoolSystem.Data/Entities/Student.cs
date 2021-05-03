using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Data.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DoB { get; set; }
        public int Year { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
