using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.Entities;

public class Courses
{
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseDescription { get; set; }
    
    public int InstructorId { get; set; }
    public int CategoryId { get; set; }
}
