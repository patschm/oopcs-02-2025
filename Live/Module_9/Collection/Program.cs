using System.Collections;

namespace Collection;

internal class Program
{
    static void Main(string[] args)
    {
        //ArrayList list = new ArrayList();
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        foreach(int i in list)
        {
            Console.WriteLine(i);
        }

        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("een", 1);
        dict.Add("twee", 2);

        Console.WriteLine(dict["twee"]);
    }
}
