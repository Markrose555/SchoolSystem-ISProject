using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.Subject
{
    public class SubjectCreateModel
    {
        [Required(ErrorMessage = "You must enter a name for the Subject of the Class")]
        public string Name { get; set; }
    }
}
