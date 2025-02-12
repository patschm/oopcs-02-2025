using Bogus;

namespace Registratie;

internal class Program
{
    static void Main(string[] args)
    {
        Naam n = new Naam("Hans");

        //string naam = n;


        var faker = new Faker<Persoon>();
        List<Persoon> people = faker
            .RuleFor(p=>p.Id, fak=>fak.UniqueIndex)
            .RuleFor(p=>p.Voornaam, fak=>new Naam(fak.Name.FindName()))
            .RuleFor(p=>p.Achternaam, fak=>new Naam(fak.Name.LastName()))
            .RuleFor(p=>p.GeboorteDatum, fak=>fak.Person.DateOfBirth)
            .Generate(10).ToList();

        Console.WriteLine("Geef de eerste letter van de voornaam");
        var first = Console.ReadLine()?.ToUpper();

        var query = people.Where(p => p.Voornaam.Value.StartsWith(first)).OrderBy(p => p.GeboorteDatum);
        //var query = from p in people where p.Voornaam.StartsWith(first) orderby p.GeboorteDatum select p;


        foreach (Persoon p in people)
        {
            Console.WriteLine($"[{p.Id}] {p.Voornaam} {p.Achternaam} ({p.GeboorteDatum.Date})");
        }
    }
}
