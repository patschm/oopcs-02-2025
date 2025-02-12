namespace DeRadio;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation r539 = new RadioStation();
        r539.Message += ViaEther;
        r539.Message += ViaKabel;
        r539.Message += ViaPostduif;
        r539.Message += ViaSMS;
        r539.Message += ViaEther;
        r539.Message += ViaKabel;
        r539.Message += ViaPostduif;
        r539.Message += ViaSMS;
        r539.Message += ViaEther;
        r539.Message += ViaKabel;
        r539.Message += ViaPostduif;
        r539.Message += ViaSMS;
        r539.Message += ViaEther;
        r539.Message += ViaKabel;
        r539.Message += ViaPostduif;
        r539.Message += ViaSMS;

        r539.Broadcast();
    }

    static void ViaEther(string msg)
    {
        Console.WriteLine($"Via Ether ontvangen: {msg}");
    }
    static void ViaKabel(string msg)
    {
        Console.WriteLine($"Via Kabel ontvangen: {msg}");
    }
    static void ViaSMS(string msg)
    {
        Console.WriteLine($"Via SMS ontvangen: {msg}");
    }
    static void ViaPostduif(string msg)
    {
        Console.WriteLine($"Via Postduif ontvangen: {msg}");
    }
}
