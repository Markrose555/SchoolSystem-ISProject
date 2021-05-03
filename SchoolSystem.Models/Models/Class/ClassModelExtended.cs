using SchoolSystem.Models.Models.StudentClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Models.Models.Class
{
    public class ClassModelExtended
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public IEnumerable<StudentClassModel> StudentClasses { get; set; }
    }
}
