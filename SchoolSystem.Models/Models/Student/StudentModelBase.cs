﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SchoolSystem.Models.Models.Student
{
    public class StudentModelBase
    {
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string StudentSurname { get; set; }
        [DisplayName("Date of Birth")]
        public DateTime StudentDoB { get; set; }
        [Required]
        public int StudentYear { get; set; }
    }
}
