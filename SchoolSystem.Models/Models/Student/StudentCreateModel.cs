﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.Student
{
    public class StudentCreateModel
    {
        [Required(ErrorMessage = "Student Name is requires")]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime DoB { get; set; }
        [Required]
        public int Year { get; set; }
    }
}
