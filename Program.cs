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
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("Linke Pfeiltaste wurde gedrückt."); // cw nicht notwendig ? 
                }
            }
        }

    }
}
    

