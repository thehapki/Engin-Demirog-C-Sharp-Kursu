﻿using CSharpCourseTrainingOne.Abstract;

namespace CSharpCourseTrainingOne.Concrete;

public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        throw new NotImplementedException();
    }

    public bool CheckPerson(Person person)
    {
        return true;
    }

    public List<Person> GetList()
    {
        throw new NotImplementedException();
    }
}
