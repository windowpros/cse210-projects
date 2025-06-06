using System.IO.Compression;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("BOB");

        Person myPerson = new Person("Bob", "Taylor", 34);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceman = new PoliceMan("Jeremy", "Anderson", 68, "Bat");
        Console.WriteLine(myPoliceman.GetPersonInformation());
        Console.WriteLine(myPoliceman.GetPoliceManInformation()); // This displays the full information; everything in GetPersonInformation AND new policeman info.

        Doctor myDoctor = new Doctor("Bob", "Jameson", 43, "knife");
        Console.WriteLine(myDoctor.GetDoctorInformation());
        
    }
}