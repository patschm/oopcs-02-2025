namespace Arrays;

internal class Program
{
    static void Main(string[] args)
    {
        // Arrays zijn verzamelingen.
        // Aaneengesloten geheugen.
        // Zijn immutable. Je kunt ze niet wijzigen in size.
        // Werkt dan ook met offset.

        //int[] intarray = new int[10] {1,2,3,4,5,6,7,8,9, 10};
        //int[] intarray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //int[] intarray =  { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] intarray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        intarray[0] = 1;

        Console.WriteLine(intarray[4]);

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine(matrix[1,1]);

        // Helaas! Geen blokhaak
        //int[,] matrix3 = { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < intarray.Length; i++) 
        { 
        
            int tmp = intarray[i];
            Console.WriteLine(tmp);
        }
        foreach(int tmp in intarray)
        {
            Console.WriteLine(tmp);
        }

    }
}
