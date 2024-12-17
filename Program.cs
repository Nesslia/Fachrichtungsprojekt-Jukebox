using System.Drawing;
using System.Reflection;
using TrueColorConsole;

namespace JukeboxProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JukeboxBild.MyIMG("JukeBox.png");

            string[] mp3Pfad = { @"Lieder\TheBeattles-YellowSubmarine.wav", @"Lieder\FoolsGarden-LemonTree.wav", @"Lieder\Scorpions-WindOfChange.wav", @"Lieder\dmx-x_gon_give_it_to_ya.mp3", @"Lieder\fettes_brot-jein.mp3", @"Lieder\RickAstley-NeverGonnaGiveYouUp.wav" };
            string hauptOrdner = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string[] ganzerPfad = { Path.Combine(hauptOrdner, mp3Pfad[0]), Path.Combine(hauptOrdner, mp3Pfad[1]), Path.Combine(hauptOrdner, mp3Pfad[2]), Path.Combine(hauptOrdner, mp3Pfad[3]), Path.Combine(hauptOrdner, mp3Pfad[4]), Path.Combine(hauptOrdner, mp3Pfad[5]) };
            string[] coverImg = { "YellowSubmarine.png", "LemonTree.png", "scorpions.png", "dmxdog.png", "jein.png", "Rick.png" };



            Jukebox.LiedHinzufuegen(new Lied("Yellow Submarine", "The Beatles", @ganzerPfad[0],
               Path.Combine(hauptOrdner, @"\TitleBilder\", @coverImg[0])));
            Jukebox.LiedHinzufuegen(new Lied("Lemon Tree", "Fools Garden", @ganzerPfad[1],
               Path.Combine(hauptOrdner, @"\TitleBilder\", @coverImg[1])));
            Jukebox.LiedHinzufuegen(new Lied("Wind of Change", "Scorpions", @ganzerPfad[2],
               Path.Combine(hauptOrdner, @"\TitleBilder\", @coverImg[2])));
            Jukebox.LiedHinzufuegen(new Lied("X gon give it to ya", "DMX", @ganzerPfad[3],
               Path.Combine(hauptOrdner, @"\TitleBilder\", @coverImg[3])));
            Jukebox.LiedHinzufuegen(new Lied("jein", "Fettes Brot", @ganzerPfad[4],
               Path.Combine(hauptOrdner, @"\TitleBilder\", @coverImg[4])));
            Jukebox.LiedHinzufuegen(new Lied("Never gonna give you up", "Rick Astley", @ganzerPfad[5],
               Path.Combine(hauptOrdner, @"\TitleBilder\", @coverImg[5])));

            Steuerung.StartSteuerung();

        }

    }
}






