namespace Registratie;

// records zijn immutable
public record Naam(string Value)
{

    public static implicit operator string(Naam Naam)
    {
        return Naam.Value;
    }
    public override string ToString()
    {
        return Value;
    }
}

public class Persoon
{
    public int Id { get; set; }
    public Naam? Voornaam { get; set; }
    public Naam? Achternaam { get; set; }
    public DateTime GeboorteDatum { get; set; }
}
