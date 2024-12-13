using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace JukeboxProjekt
{
    public class Lied
    {
        public string Titel { get; set; }               //Title des Lieds
        public string Kuenstler { get; set; }
        public string Dateipfad { get; set; }             //Pfad zum Lied
        public string BildPfad { get; set; }                //pfad titlebilder der lieder


        public Lied(string titel, string kuenstler, string dateipfad, string bildPfad)
        {
            Titel = titel;
            Kuenstler = kuenstler;
            Dateipfad = dateipfad;
            BildPfad = bildPfad;
        }
    


    }



}
