namespace TheFirm;

class Patrick : Employee
{
    public void DoetMaarWat()
    {
        Console.WriteLine("Patrick doet maar wat");
    }

    public override void Produceert()
    {
        DoetMaarWat();
    }
}
