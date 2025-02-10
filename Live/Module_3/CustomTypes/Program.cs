namespace CustomTypes;

internal class Program
{
    static void Main(string[] args)
    {
        int dagvdweek = 4;
        DagVanDeWeek dayOfWeek = DagVanDeWeek.Donderdag;
        Console.WriteLine(dayOfWeek);
        Console.WriteLine((int)dayOfWeek);
        Console.WriteLine((DagVanDeWeek)dagvdweek);

    }
}

// Met een enumeratie geef ik betekenis aan een getal.
enum DagVanDeWeek : ulong
{
    Maandag = 1,
    Dinsdag = 2,
    Woensdag = 4,
    Donderdag = 8,
    Vrijdag = 16,
    Zaterdag = 32,
    Zondag = 64,
}
