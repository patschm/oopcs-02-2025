using IEEE;

namespace Logitech;

public class Camera: IDetectable
{
    public void Detect()
    {
        Record();
    }

    public void Record()
    {
        Console.WriteLine("De camera start de opname");
    }
}
