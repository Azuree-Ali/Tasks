using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Student_System.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Unicode(true)]
        [MaxLength(100)]
        public string Name { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Homework> Homeworks { get; set; }
    }
}
