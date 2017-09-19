// Microsoft
using System;
using System.Collections.Generic;

namespace Aplikace.Knihovny
{
    class Knihovna_Informace
    {
        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - String:
        //Static:
        public static string Text_MessangerBox(List<string> HodnotaList)
        {
            if (HodnotaList.Count == 1)
                return string.Format("Aplikace nenalezla knihovnu: {0}.dll, a proto bude řádně ukončen!", HodnotaList[0]);
            else
            {
                string text = null;
                for (int i = 0; i < HodnotaList.Count; i++)
                {
                    if (i == HodnotaList.Count - 1)
                        text += string.Format("{0}.dll", HodnotaList[i]);
                    else
                        text += string.Format("{0}.dll, ", HodnotaList[i]);
                }

                return string.Format("Aplikace nenalezla knihovny: ({0}), a proto bude řádně ukončen!", text);
            }
        }

        public static string Text_MessangerBox()
        {
            return "Jejda";
        }
    }
}
