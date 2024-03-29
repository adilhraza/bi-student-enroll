﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentCourseApp.Data.Entity
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string CourseCode { get; set; }

        [Required]
        public string CourseName { get; set; }

        [StringLength(150, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        public string TeacherName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        // relationship property
        public virtual ICollection<Student> Students { get; set; }
    }
}
