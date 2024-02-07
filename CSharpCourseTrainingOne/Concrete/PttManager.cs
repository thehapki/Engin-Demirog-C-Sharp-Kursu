using CSharpCourseTrainingOne.Abstract;

namespace CSharpCourseTrainingOne.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person) == true)
        {
            Console.WriteLine(person.FirstName + " için maske verildi.");

        }
        else
        {
            Console.WriteLine(person.FirstName + " için maske verilemedi !!!");
        }
    }
}
