// Microsoft
using System;

namespace Client.Knihovny
{
    public class Knihovna_Jazyk
    {
        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - Stirng:
        /// <summary>
        /// Vyhledá správný text podle nastaveného Jazyka...
        /// </summary>
        /// <param name="HodnotaInt">Index textu</param>
        public string Text_PrehledTextu(int HodnotaInt)
        {
            return Text_DatabazeTextu[HodnotaInt];
        }

        //Private - String:
        private string[] Text_DatabazeTextu =
        {
            /*0*/"Zadal si nesprávné Heslo.", /*1*/"Chyba Databáze...",
            /*2*/"Prosím přihlaš se...", /*3*/"Přihlašuji se...",
            /*4*/"Verze", /*5*/"Deník", /*6*/"Přihlášení", /*7*/"Chyba",
            /*8*/"Informace o chybě...", /*9*/"Jejda", /*10*/"Načítání",
            /*11*/"Načítání Deníku...", /*12*/"Připojování...", /*13*/"Načítání..."
        };
    }
}
