using IEEE;

namespace Heras;

public class Hek: IDetectable
{
    public void Detect()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("Het hek gaat open");
    }
}
