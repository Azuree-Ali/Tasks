using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Student_System.Models
{
    public enum ContentType
    {
        Application,
        Pdf,
        Zip
    }
    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }
        [Unicode(false)]
        public string Content { get; set; }
        public ContentType ContentType { get; set; }
        public DateTime SubmissionTime { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
