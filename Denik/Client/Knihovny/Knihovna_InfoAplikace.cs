// Microsoft
using System.Collections.Generic;

// Client
using Client.Knihovny.Rozdeleni;

namespace Client.Knihovny
{
    public class Knihovna_InfoAplikace
    {
        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Knihovna_InfoAplikace()
        {
            if (Text_Deniky == null)
                Text_Deniky = new List<Rozdeleni_Denik>();
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - String:
        public string Get_VerzeAplikace
        {
            get
            {
                return Text_VerzeAplikace;
            }
        }

        public string GetSet_IDUzivatel
        {
            get
            {
                return Text_IDUzivatel;
            }
            set
            {
                Text_IDUzivatel = value;
            }
        }

        //Public - List:
        //<Rozdeleni_Denik>
        public List<Rozdeleni_Denik> GetSet_Deniky
        {
            get
            {
                return Text_Deniky;
            }
            set
            {
                Text_Deniky = value;
            }
        }

        //Static:
        public static string Text_VerzeAplikace { get; set; }
        
        //Private - String:
        //Static:
        private static string Text_IDUzivatel { get; set; }

        //Private - List:
        //<Rozdeleni_Denik>
        //Static:
        private static List<Rozdeleni_Denik> Text_Deniky { get; set; }
    }
}
