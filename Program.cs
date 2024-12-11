using System.Drawing;
using TrueColorConsole;

namespace JukeboxProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {

            JukeboxBild.MyIMG("JukeBox.png");
            //cursor feste position ?
           

            Steuerung steuerung = new Steuerung();
            steuerung.StartSteuerung();
        }

    }
}
    

