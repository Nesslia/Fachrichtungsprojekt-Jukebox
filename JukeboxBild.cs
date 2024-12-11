using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueColorConsole;

namespace JukeboxProjekt
{
    internal class JukeboxBild
    {

        internal static void MyIMG(string img_name) //hier wird der Name ünergeben zb. Bild.png
        {
            string gdir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            
            gdir += @"\ressource\" + img_name;
            int res_x = 100;
            int res_y = 90;


            Bitmap image = new Bitmap(new Bitmap(gdir), new Size(res_x, res_y));
            //Für res_x habe ich ein Feld mit int 240 und bei res_y ein int mit 100. Für die Bilder sollten ebenfalls die DIMENSIONEN 240px x 100px haben

            VTConsole.Enable();

            for (int y = 0; y <= res_y - 1; y = y + 2)
            {
                for (int x = 0; x <= res_x - 1; x++)
                {
                    Color color = image.GetPixel(x, y);

                    VTConsole.Write(((char)'\u2588').ToString(), Color.FromArgb(color.R, color.G, color.B));
                    //Achtung hier wird die Nuget Bibliothek True Color Console


                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();

                VTConsole.Disable();


            }


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.SetCursorPosition(38, 18);
            Console.Write("1");

            Console.SetCursorPosition(46, 18);
            Console.Write("2");

            Console.SetCursorPosition(54, 18);
            Console.Write("3");

            Console.SetCursorPosition(38, 21);
            Console.Write("4");

            Console.SetCursorPosition(46, 21);
            Console.Write("5");

            Console.SetCursorPosition(54, 21);
            Console.Write("6");


            Console.SetCursorPosition(38, 18);
        }
    }
}
