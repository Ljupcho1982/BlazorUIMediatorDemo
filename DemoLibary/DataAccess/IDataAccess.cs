using DemoLibary.Model;

namespace DemoLibary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel Insertpeople(string FirstName, string LastName);
    }
}