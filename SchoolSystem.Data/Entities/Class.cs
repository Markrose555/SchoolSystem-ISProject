using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolSystem.Data.Entities
{
    public class Class
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
