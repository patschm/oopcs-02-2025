namespace EvolutieDerDelegates;

delegate int MathDel(int x, int y);

internal class Program
{
    static void Main(string[] args)
    {
        // 2002/2003. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1,2);
        result = m1.Invoke(1, 2);


        // 2005. Framework 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;

        MathDel m3 = delegate (int a, int b)
        {
            return a + b + c;
        };

        result = m3(3, 4);


        // 2007. Framework 3.0/3.5
        // Welcome Lambda!
        MathDel m4 =  (a, b) => a + b + c;
        result = m4(4, 5);

        // Procedures
        Action<string> a1 = (sp) => Console.WriteLine(sp);
        a1("Ha!");

        // Functions
        Func<int> f1 = () => 42;
        result = f1();

        Func<int, int, int> f2 = Add;
        result = f2(10, 11);


        result = LocalAdd(12,13);

        Console.WriteLine(result);

        int LocalAdd(int a, int b)
        {
            return a + b + c;
        }
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}
