namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        var simon = new SimonVanDeMeer();
        var willem = new WillemKlein();

        willem.Bereken(simon.Add, 4, 5);
        willem.Bereken(simon.Subtract, 9, 3);
        willem.Bereken(Multiply, 4, 5);

        Berekening math = simon.Add;
        math += simon.Subtract;
        math +=  simon.Add;
        math += simon.Add;
        math += simon.Subtract;


        foreach (var v in math.GetInvocationList())
        {
            Console.WriteLine(v.Method.Name);
        }


        int result = math(1, 2);

        Console.WriteLine(result);
    }

    static int Multiply(int a, int b)
    { 
        return a * b; 
    }
}
