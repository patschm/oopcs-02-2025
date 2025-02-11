namespace DeTorenVanPisa;

public class Lift
{
    private int _huidigeVerdieping = 0;

    public int HuidigeVerdieping 
    { 
        get 
        { 
            return _huidigeVerdieping; 
        } 
    }

    public void RoepLift(int doelVerdieping)
    {
        Console.WriteLine("Zzzzt");
        _huidigeVerdieping = doelVerdieping;
    }
}