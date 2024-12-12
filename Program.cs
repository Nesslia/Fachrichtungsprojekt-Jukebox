using System.Drawing;
using TrueColorConsole;

namespace JukeboxProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JukeboxBild.MyIMG("JukeBox.png");
                         
            

            Jukebox.LiedHinzufuegen(new Lied("Never gonna give you up", "Rick Astley", @"C:\Umschulung FI\SE-GL\Fachrichtungsprojekt Jukebox\Lieder\RickAstley-NeverGonnaGiveYouUp.wav"));
            Jukebox.LiedHinzufuegen(new Lied("Lemon Tree", "Fools Garden", @"C:\Umschulung FI\SE-GL\Fachrichtungsprojekt Jukebox\Lieder\FoolsGarden-LemonTree.wav"));
            Jukebox.LiedHinzufuegen(new Lied("Wind of Change", "Scorpions", @"C:\Umschulung FI\SE-GL\Fachrichtungsprojekt Jukebox\Lieder\Scorpions-WindOfChange.wav"));
            Jukebox.LiedHinzufuegen(new Lied("X gon give it to ya", "DMX", @"C:\Umschulung FI\SE-GL\Fachrichtungsprojekt Jukebox\Lieder\dmx-x_gon_give_it_to_ya.mp3"));
            Jukebox.LiedHinzufuegen(new Lied("jein", "Fettes Brot", @"C:\Umschulung FI\SE-GL\Fachrichtungsprojekt Jukebox\Lieder\fettes_brot-jein.mp3"));
            Jukebox.LiedHinzufuegen(new Lied("Yellow Submarine", "The Beatles", @"C:\Umschulung FI\SE-GL\Fachrichtungsprojekt Jukebox\Lieder\TheBeattles-YellowSubmarine.wav"));

            Steuerung.StartSteuerung();

        }

    }
}
    

