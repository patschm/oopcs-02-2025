namespace MoreInteraction;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick p = new Patrick();
        Tim t = new Tim();

        //p.DoeIets();
        t.Execute(p.DoeIets);
    }
}
