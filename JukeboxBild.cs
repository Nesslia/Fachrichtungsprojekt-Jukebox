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

        internal static void MyIMG(string jukeboxBildName, string titelBildName = null)
        {
            string gdir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string jukeboxPath = Path.Combine(gdir, "ressource", jukeboxBildName);

            if (!File.Exists(jukeboxPath))                                                                          // checkt ob bild überhaupt existiert
            {
                Console.WriteLine($"Jukeboxbild nicht gefunden: {jukeboxPath}");
                return;
            }

            int res_x = 100;                                                                                            // Größe Jukebox
            int res_y = 90;
            int titleRes_x = 50;                                                                                        // Größe Titelbild
            int titleRes_y = 45;
            
            using (Bitmap jukeboxImage = new Bitmap(jukeboxPath))
            {
                Bitmap resizedJukeboxImage = new Bitmap(jukeboxImage, new Size(res_x, res_y));

                VTConsole.Enable();

                Console.SetCursorPosition(0, 0);
                                                                                               
                for (int y = 0; y < res_y; y += 2)                                                  // Ausgabe Jukeboxbild
                {
                    for (int x = 0; x < res_x; x++)
                    {
                        Color color = resizedJukeboxImage.GetPixel(x, y);
                        VTConsole.Write(((char)'\u2588').ToString(), Color.FromArgb(color.R, color.G, color.B));
                    }
                    Console.WriteLine();
                }

                if (!string.IsNullOrEmpty(titelBildName))                                        // Überprüft, ob Titelbild vorhanden ist und gibt es aus
                {
                    string titelPath = Path.Combine(gdir, "ressource", titelBildName);
                    if (File.Exists(titelPath))
                    {
                        using (Bitmap titelImage = new Bitmap(titelPath))
                        {
                            Bitmap resizedTitelImage = new Bitmap(titelImage, new Size(titleRes_x, titleRes_y));
                           
                            for (int y = 0; y < titleRes_y; y += 2)
                            {
                                Console.SetCursorPosition(res_x + 24 , 3+ y / 2);                         // abstand Titlebild zum jukeboxbild/oberen Bildrand
                                for (int x = 0; x < titleRes_x; x++)
                                {                                    
                                    Color color = resizedTitelImage.GetPixel(x, y);
                                    VTConsole.Write(((char)'\u2588').ToString(), Color.FromArgb(color.R, color.G, color.B));                                    
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Titelbild nicht gefunden: {titelPath}");
                    }
                }
                VTConsole.Disable();
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.SetCursorPosition(41, 20);
            Console.Write("1");

            Console.SetCursorPosition(51, 20);
            Console.Write("2");

            Console.SetCursorPosition(60, 20);
            Console.Write("3");

            Console.SetCursorPosition(41, 23);
            Console.Write("4");

            Console.SetCursorPosition(51, 23);
            Console.Write("5");

            Console.SetCursorPosition(60, 23);
            Console.Write("6");

            Console.SetCursorPosition(41, 20);
        }

    }
}
