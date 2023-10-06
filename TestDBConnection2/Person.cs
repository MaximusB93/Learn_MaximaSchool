using System.Collections;

namespace TestDBConnection2;

public class Person : IEnumerable
{
    public int PersonID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Gender { get; set; }

    public Person(int personId, string firstName, string lastName, string address, string city, string gender)
    {
        PersonID = personId;
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        City = city;
        Gender = gender;
    }
    public Person()
    {

    }

    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}