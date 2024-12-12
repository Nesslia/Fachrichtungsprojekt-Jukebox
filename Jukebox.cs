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
                // Stoppe das aktuell laufende Lied
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
            }

            // Lade und spiele das neue Lied
            Lied lied = lieder[index];
            audioFileReader = new AudioFileReader(lied.Dateipfad);
            waveOutDevice = new WaveOutEvent();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Volume = 0.05f;
            waveOutDevice.Play();
            //Console.WriteLine($"Jetzt wird gespielt: {lied.Titel} von {lied.Kuenstler}");       //wo wirds angezeigt ? position anpassen??
        }

        public static void LiedStoppen()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
               
            }
        }

        public Lied GetLied(int index)
        {
            return lieder[index];
        }
    }

}

