using System;

namespace CSharpCourseTrainingOne.Abstract;
public interface IApplicantService
{
    void ApplyForMask(Person person);
    public List<Person> GetList();
    bool CheckPerson(Person person);
}
