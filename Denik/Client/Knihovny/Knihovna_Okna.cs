// Microsoft
using System;
using System.Windows.Forms;

// Client
using Client.Okna;

namespace Client.Knihovny
{
    public class Knihovna_Okna
    {
        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - Form:
        /// <summary>
        /// Přehled listu pro okna...
        /// </summary>
        /// <param name="HodnotaByte">
        /// 0 - Okno_Error();
        /// 1 - Okno_Nacitani();
        /// 2 - Okno_Denik();
        /// </param>
        public Form Okno_PrehledSpusteni(byte HodnotaByte)
        {
            switch (HodnotaByte)
            {
                case 1:
                    return new Okno_Nacitani();
                case 2:
                    return new Okno_Denik();
                default:
                    return new Okno_Error();
            }
        }

        //Static:
        /// <summary>
        /// Základní okno, které se spustí jako první...
        /// </summary>
        public static Form Okno_ZakladSpusteni()
        {
            return new Okno_Prihlaseni(); // Okno_Prihlaseni();
        }
    }
}
