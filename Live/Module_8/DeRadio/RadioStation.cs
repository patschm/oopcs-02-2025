namespace DeRadio;

delegate void Ontvanger(string msg);

internal class RadioStation
{
    //private Ontvanger? _abonnees;

    public event Ontvanger Message;
    //{
    //    add
    //    {
    //        _abonnees += value;
    //    }
    //    remove
    //    {
    //        _abonnees -= value;
    //    }
    //}

    public void Broadcast()
    {
        Console.WriteLine("De uitzending begint");
        Message?.Invoke("Hallo luisteraars");

    }
}
