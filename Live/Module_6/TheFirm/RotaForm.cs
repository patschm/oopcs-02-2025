namespace TheFirm;

class RotaForm
{
    private IContract[] employees = new IContract[10];

    public void Hire(IContract employee)
    {
        for (int i = 0; i < employees.Length; i++)
        {
            if (employees[i] == null)
            {
                employees[i] = employee;
                return;
            }
        }
    }

    public void StartProduction()
    {
        Console.WriteLine("De stoomfluit gaat.");
        Console.WriteLine("RotaForm gaat documenten produceren");
        foreach (IContract employee in employees)
        {
            employee?.Werkt();
        }

    }
}
