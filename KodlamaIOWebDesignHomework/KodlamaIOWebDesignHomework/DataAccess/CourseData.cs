using KodlamaIOWebDesignHomework.Entities;
using KodlamaIOWebDesignHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.DataAccess;

public class CourseData : ICourse
{
    List<Courses> allCourses;

    public CourseData()
    {
        allCourses = new List<Courses>
        {
            new Courses()
            {
                CourseId = 1,
                CourseName = "C# Yazılımcı Geliştirme Kampı",
                CourseDescription= "Her pazar saat 20.00'dan 22.00'a kadar",
                CategoryId = 1,
                InstructorId = 1
            }
        };
    }

    public void AddCourse(Courses course)
    {
        allCourses.Add(course);
    }

    public void RemoveCourse(Courses course)
    {
        allCourses.Remove(course);
    }

    public void UpdateCourse(Courses course)
    {
        var tempCourseId = allCourses.FirstOrDefault(course => course.CourseId == course.CourseId);
        if (tempCourseId != null)
        {
            tempCourseId.CourseId = course.CourseId;
            tempCourseId.CourseName = course.CourseName;
            tempCourseId.CourseDescription = course.CourseDescription;
            tempCourseId.CategoryId = course.CategoryId;
            tempCourseId.InstructorId = course.InstructorId;
        }
    }

    public List<Courses> GetCourseList()
    {
        foreach (var item in allCourses)
        {
            Console.WriteLine($"Kurs Bilgileri: {item.CourseName} {item.CourseDescription} {item.CategoryId} {item.InstructorId}");
        }
        return allCourses;
    }
}
