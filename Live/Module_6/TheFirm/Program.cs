namespace TheFirm;

internal class Program
{
    static void Main(string[] args)
    {
        RotaForm company = new();
        Tim  tim = new();
        Patrick pat = new();
        Bokito bok = new();
        IContract computer = new Computer();


        company.Hire(tim);
        company.Hire(pat);
        company.Hire(bok);
        company.Hire(computer);

        company.StartProduction();
    }
}
