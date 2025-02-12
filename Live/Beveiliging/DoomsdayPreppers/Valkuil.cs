using IEEE;

namespace DoomsdayPreppers;

public class Valkuil: IDetectable
{
    public void Detect()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil met spiezen gaat open");
    }
}
