using KodlamaIOWebDesignHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.Interface;

public interface ICourse
{
    public void AddCourse(Courses course);
    public void UpdateCourse(Courses course);
    public void RemoveCourse(Courses course);

    List<Courses> GetCourseList();
}
