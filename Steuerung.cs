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
        private List<(int, int)> positionen;
        private int aktuellePosition;

        public Steuerung()
        {
            positionen = new List<(int, int)>
            {
                (38, 18), (46, 18), (54,18), 
                (38, 21), (46, 21), (54,21)
            };
            //aktuellePosition = 0;
        }

        public void StartSteuerung()
        {
            Console.CursorVisible = true;

            while (true)
            {
                RotePosition();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        aktuellePosition = (aktuellePosition % 3 == 0) ? aktuellePosition : aktuellePosition - 1;
                        break;
                    case ConsoleKey.RightArrow:
                        aktuellePosition = (aktuellePosition % 3 == 2) ? aktuellePosition : aktuellePosition + 1;
                        break;
                    case ConsoleKey.UpArrow:
                        aktuellePosition = (aktuellePosition < 3) ? aktuellePosition : aktuellePosition - 3;  
                        break;
                    case ConsoleKey.DownArrow:
                        aktuellePosition = (aktuellePosition >= 3) ? aktuellePosition : aktuellePosition + 3;
                        break;
                    case ConsoleKey.Escape:
                        return;
                }
            }
        }

        private void RotePosition()
        {
            Console.SetCursorPosition(positionen[aktuellePosition].Item1, positionen[aktuellePosition].Item2);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(aktuellePosition+1);
            Console.ResetColor();
            
        }

    }
}
