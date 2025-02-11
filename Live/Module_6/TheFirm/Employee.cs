
namespace TheFirm;

abstract class Employee : Person, IContract
{
    public abstract void Produceert();

    public void Werkt()
    {
        Produceert();
    }
}
