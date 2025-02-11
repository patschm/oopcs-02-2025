namespace TheFirm;

class Tim : Employee
{
    public override void Produceert()
    {
        Programmeert();
    }

    public void Programmeert()
    {
        Console.WriteLine("Tim programeert iets met documenten");
    }
}
