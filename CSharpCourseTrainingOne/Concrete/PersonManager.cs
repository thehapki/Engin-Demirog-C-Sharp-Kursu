using CSharpCourseTrainingOne.Abstract;
using MernisServiceReference;

namespace CSharpCourseTrainingOne.Concrete;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }
    public List<Person> GetList()
    {
        return null;
    }
    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.Tc, person.FirstName, person.LastName, person.Year))).Result.Body.TCKimlikNoDogrulaResult;
    }
}
