using DemoLibary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {

        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel
            {

                Id = 1,
                FirstName = "Ljupcho",
                LastName = "shemov"


            });
            people.Add(new PersonModel
            {

                Id = 1,
                FirstName = "Trajche",
                LastName = "Trajkov"


            });



        }
        public List<PersonModel> GetPeople()
        {

            return people;
        }

        public PersonModel Insertpeople(string FirstName, string LastName)
        {
            PersonModel person = new() { FirstName = FirstName, LastName = LastName };
            person.Id = people.Max(x => x.Id) + 1;

            people.Add(person);
            return person;

        }


    }


}
