namespace TheFirm;

internal class Computer : IContract
{
    public void Produceert()
    {
        Console.WriteLine("De computer doet het allemaal razendsnel");
    }

    public void Werkt()
    {
        Produceert();   
    }
}
