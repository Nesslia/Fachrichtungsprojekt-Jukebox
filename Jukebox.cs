using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace JukeboxProjekt
{
    public class Jukebox
    {
        private static List<Lied> lieder = new List<Lied>();
        private static IWavePlayer waveOutDevice;
        private static AudioFileReader audioFileReader;

        

        public static void LiedHinzufuegen(Lied lied)
        {
            lieder.Add(lied);
        }

        public static void LiedAbspielen(int index)
        {
            if (waveOutDevice != null)
            {                
                waveOutDevice.Stop();                                                        // stoppt das aktuell laufende Lied
                waveOutDevice.Dispose();
            }
            
            Lied lied = lieder[index];                                                      // lädt und spielt das neue Lied
            JukeboxBild.MyIMG("JukeBox.png", Path.GetFileName(lied.BildPfad));
            audioFileReader = new AudioFileReader(lied.Dateipfad);
            waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Volume = 0.05f;
            waveOutDevice.Play();


            Console.SetCursorPosition(120, 30);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Jetzt wird gespielt: '{lied.Titel}' von '{lied.Kuenstler}'                 ");       
            
            Console.ResetColor();           
        }

        public static void LiedStoppen()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();               
            }
        }

       
    }

}

