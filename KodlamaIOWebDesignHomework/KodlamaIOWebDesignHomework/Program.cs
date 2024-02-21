using KodlamaIOWebDesignHomework.DataAccess;
using KodlamaIOWebDesignHomework.Entities;

Categories category = new Categories() { CategoryId = 3, CategoryName = "Oyun Geliştirme" };
CategoryData categoryData = new CategoryData();
categoryData.UpdateCategory(category);

Instructors instructors = new Instructors() { InstructorId = 3, InstructorName = "Mehmet Allıpullu" };
InstructorData instructorData = new InstructorData();
instructorData.UpdateInstructor(instructors);

Courses course = new Courses()
{
    CourseId = 4,
    CourseName = "Oyun Programlamaya Giriş",
    CourseDescription = "Her pazar saat 12.00 - 15.00 arası",
    CategoryId = 3,
    InstructorId = 3,
};
CourseData courseData = new CourseData();
courseData.UpdateCourse(course);



categoryData.GetCategoryList();

