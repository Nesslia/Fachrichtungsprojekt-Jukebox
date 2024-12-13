using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeboxProjekt
{
    public class Steuerung
    {
        private static List<(int, int)> positionen = new List<(int, int)>
            {
                (41, 20), (51,20), (60,20),
                (41, 23), (51, 23), (60,23)
            };

        private static int aktuellePosition;
        private static int letztePosition;
        private Jukebox jukebox;
        private static bool playerStop = true;
        public Steuerung(Jukebox jukebox)
        {
            this.jukebox = jukebox;
        }


        public static void StartSteuerung()
        {
            Console.CursorVisible = true;

            while (true)
            {
                RotePosition();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    
                    case ConsoleKey.LeftArrow:
                        letztePosition = aktuellePosition;
                        aktuellePosition = (aktuellePosition % 3 == 0) ? aktuellePosition : aktuellePosition - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        letztePosition = aktuellePosition;
                        aktuellePosition = (aktuellePosition % 3 == 2) ? aktuellePosition : aktuellePosition + 1;       //bewegung des Cursors durch Pfeiltasten
                        break;
                    case ConsoleKey.UpArrow:
                        letztePosition = aktuellePosition;
                        aktuellePosition = (aktuellePosition < 3) ? aktuellePosition : aktuellePosition - 3;  
                        break;
                    case ConsoleKey.DownArrow:
                        letztePosition = aktuellePosition;
                        aktuellePosition = (aktuellePosition >= 3) ? aktuellePosition : aktuellePosition + 3;
                        break;
                    case ConsoleKey.Enter:
                        if (playerStop)
                        {
                            Jukebox.LiedAbspielen(aktuellePosition);
                            playerStop = false;
                        }
                        else
                        {                            
                            Jukebox.LiedStoppen();
                            
                            playerStop = true;
                        }
                        Thread.Sleep (300);
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        
        
        private static void RotePosition()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(positionen[letztePosition].Item1, positionen[letztePosition].Item2);
            Console.Write(letztePosition+1);
            Console.SetCursorPosition(positionen[aktuellePosition].Item1, positionen[aktuellePosition].Item2);  //angesteuerte "Knöpfe" sind nun rot hinterlegt
           
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(aktuellePosition+1);
            Console.ResetColor();
            
        }
        
    }
}
