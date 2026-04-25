using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Student_System.Models
{
    public enum ResourceType
    {
        Video,
        Presentation,
        Document
    }
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        [Unicode(true)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Unicode(false)]
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
    }
}
