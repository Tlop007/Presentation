// Microsoft
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

// Client
using Client.Knihovny;

namespace Aplikace.Knihovny
{
    class Knihovna_Spusteni : Knihovna_Informace
    {
        //Private - List:
        //Static:
        private static List<string> dllSoubory_Spatne;

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - Void:
        //Static:
        /// <summary>
        /// Spustí základní okno pro tuto aplikaci...
        /// </summary>
        /// <param name="HodnotaString">Zde vložit string, pro kontrolu knihovny, která slouží s polu s programem</param>
        public static void Funkce_SpusteniOkna(string HodnotaString_Client, string HodnotaString_Server)
        {
            try
            {
                if (Kontrola_OvereniDLL(HodnotaString_Client, HodnotaString_Server))
                {
                    // Připsání dat do jiné knihovny...
                    Funkce_SetInfo();

                    // Spuštění Okna...
                    Program.Run();
                    
                }
                else
                    MessageBox.Show(Text_MessangerBox(dllSoubory_Spatne), Text_MessangerBox(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Text_MessangerBox(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Private - Bool:
        //Static:
        private static bool Kontrola_OvereniDLL(string HodnotaString_Client, string HodnotaString_Server)
        {
            dllSoubory_Spatne = new List<string>();
            string[] dllSoubory_Overovani = { HodnotaString_Client, HodnotaString_Server };

            foreach (string dllSoubor_Overeni in dllSoubory_Overovani)
            {
                if (!File.Exists(string.Format("{0}.dll", dllSoubor_Overeni)))
                    dllSoubory_Spatne.Add(dllSoubor_Overeni);
            }

            if (dllSoubory_Spatne.Count <= 0)
                return true;
            else
                return false;
        }

        //Private - Void:
        //Static:
        private static void Funkce_SetInfo()
        {
            Knihovna_InfoAplikace.Text_VerzeAplikace = Application.ProductVersion;
        }
    }
}
