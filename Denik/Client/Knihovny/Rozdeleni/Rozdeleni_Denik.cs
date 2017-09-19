// Microsoft
using System;

namespace Client.Knihovny.Rozdeleni
{
    public class Rozdeleni_Denik
    {
        //Public - String:
        public string IDDenik { get; set; }
        public string Text { get; set; }
        public string Date { get; set; }

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Rozdeleni_Denik(string IDDenik, string Text, string Date)
        {
            this.IDDenik = IDDenik;
            this.Text = Text;
            this.Date = Date;
        }
    }
}
