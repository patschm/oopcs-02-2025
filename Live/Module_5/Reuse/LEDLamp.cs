namespace Reuse;

internal class LEDLamp : Lamp
{
    public sealed override void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De LEDlamp brandt met intensiteit {Intensiteit} lumen");
        Console.ResetColor();
    }
    public LEDLamp()
    {
        Wattage = 8;
    }
}
