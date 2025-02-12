namespace MoreInteraction;

delegate void Proc();

internal class Tim
{
    public void Execute(Proc argument)
    {
        Console.WriteLine("Tim voert uit:");
        argument();
    }
}
