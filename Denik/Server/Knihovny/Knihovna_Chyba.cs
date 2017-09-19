// Microsoft
using System;

namespace Server.Knihovny
{
    public class Knihovna_Chyba
    {
        //Private - String:
        //Static:
        private static string Text_InfoChyba { get; set; }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - String:
        public string Get_InfoChyba
        {
            get
            {
                return Text_InfoChyba;
            }
        }

        public string Set_InfoChyba
        {
            set
            {
                Text_InfoChyba = value;
            }
        }
    }
}
