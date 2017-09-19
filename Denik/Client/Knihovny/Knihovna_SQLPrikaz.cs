// Microsoft
using System;

namespace Client.Knihovny
{
    class Knihovna_SQLPrikaz
    {
        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - String:
        /// <summary>
        /// Veškerý přehled příkazů, pro SQL...
        /// </summary>
        /// <param name="HodnotaInt">Index příkazu</param>
        public string Text_PrehledPrikazu(int HodnotaInt)
        {
            return Text_DatabezePrikazu[HodnotaInt];
        }

        //Private - String:
        private string[] Text_DatabezePrikazu =
        {
            /*0*/"select * from Table_Uzivatel",
            /*1*/"select IDDenik, Text, Date from Table_Denik where ID ="
        };
    }
}
