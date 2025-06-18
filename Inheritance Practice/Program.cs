using System.IO.Compression;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("BOB");

        // Person myPerson = new Person("Bob", "Taylor", 34);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceman = new PoliceMan("Jeremy", "Anderson", 68, "Bat",65,23);
        Console.WriteLine(myPoliceman.GetPersonInformation());
        Console.WriteLine(myPoliceman.GetPersonInformation()); // This displays the full information; everything in GetPersonInformation AND new policeman info.

        Doctor myDoctor = new Doctor("Bob", "Jameson", 43, "knife",500000);
        Console.WriteLine(myDoctor.GetPersonInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceman);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }

    }

    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine(person.GetPay());
    }
}