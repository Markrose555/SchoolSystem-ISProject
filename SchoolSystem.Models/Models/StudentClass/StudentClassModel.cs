using SchoolSystem.Models.Models.Class;
using SchoolSystem.Models.Models.Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Models.StudentClass
{
    public class StudentClassModel
    {
        public int Id { get; set; }
        public StudentModelBase Student { get; set; }
        public ClassModelBase Class { get; set; }
        public int Grade { get; set; }
    }
}
