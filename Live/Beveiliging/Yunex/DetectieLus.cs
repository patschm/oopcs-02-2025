using IEEE;

namespace Yunex;

public delegate void Signal();

public class DetectieLus
{
    private IDetectable[]  devices = new IDetectable[10];
    private Signal signals;

    public void Connect(Signal signal)
    {
        signals += signal;
    }
    public void Connect(IDetectable device)
    {
        for (int i = 0; i < devices.Length; i++)
        {
            if (devices[i] == null)
            {
                devices[i] = device;
                return;
            }
        }
    }
    public void Detecteert()
    {
        Console.WriteLine("De detectielus ziet iets...");
        foreach (IDetectable device in devices)
        {
            device?.Detect();
        }

        signals?.Invoke();
    }
}
