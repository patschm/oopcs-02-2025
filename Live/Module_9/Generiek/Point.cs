namespace Generiek;

// Generieke class
internal class Point<U> where U :  IFormattable
{
    public U X { get; set; }
    public U Y { get; set; }

    public static P Create<P>() where P : new()
    {
        return new P();
    }

    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}
