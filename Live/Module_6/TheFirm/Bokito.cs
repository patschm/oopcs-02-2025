
namespace TheFirm;

internal class Bokito : IContract
{
    public void Produceert()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }

    void IContract.Werkt()
    {
        Produceert();
    }
}
