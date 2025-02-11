using DoomsdayPreppers;
using Heras;
using Logitech;
using Yunex;

namespace DeBeveiliging;

internal class Program
{
    static void Main(string[] args)
    {
        Hek hek = new Hek();
        Valkuil valkuil = new Valkuil();
        Camera camera = new Camera();
        DetectieLus lus = new DetectieLus();


        lus.Detecteert();
       
    }
}
