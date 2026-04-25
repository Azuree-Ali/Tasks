using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Student_System.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Unicode(true)]
        [MaxLength(80)]
        public string Name { get; set; }
        [Unicode(true)]
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public ICollection<StudentCourses> StudentCourses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
        public ICollection<Resource> Resources { get; set; }

    }
}
