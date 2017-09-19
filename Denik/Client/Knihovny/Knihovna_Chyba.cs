// Microsoft
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

// Server
using s = Server.Knihovny;

namespace Client.Knihovny
{
    class Knihovna_Chyba : s.Knihovna_Chyba
    {
        //Private - Knihovna_Jazyk:
        private Knihovna_Jazyk knihovnaJazyk;

        //Private - Knihovna_Okna:
        private Knihovna_Okna knihovnaOkna;

        //Private - String:
        //Static:
        private static string Text_SouborInfoChyba { get; set; }

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Knihovna_Chyba()
        {
            knihovnaJazyk = new Knihovna_Jazyk();
            knihovnaOkna = new Knihovna_Okna();
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - String:
        /// <summary>
        /// Název txt souboru, který se nedávno vytvořil pro danou chybu...
        /// </summary>
        public string Get_SouborInfoChyba
        {
            get
            {
                return Text_SouborInfoChyba;
            }
        }

        //Public - Void:
        /// <summary>
        /// Funkcionalita pro vyhlášení dané chyby...
        /// </summary>
        public void Funkce_VyhlaseniChyby()
        {
            try
            {
                Funkce_VypisTextu(@"soubory\chyba", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, knihovnaJazyk.Text_PrehledTextu(9), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Funkcionalita pro vyhlášení dané chyby a otevření vyhláškového okénka...
        /// </summary>
        /// <param name="HodnotaForm">Form, který se má zavřít</param>
        public void Funkce_VyhlaseniChyby(Form HodnotaForm)
        {
            try
            {
                Funkce_VypisTextu(@"soubory\chyba", true);

                Thread th = new Thread(Funkce_SpusteniOkna);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                HodnotaForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, knihovnaJazyk.Text_PrehledTextu(9), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Private - Void:
        private void Funkce_VypisTextu(string HodnotaString, bool HodnotaBool)
        {
            // Kontrola složky...
            if (!Directory.Exists(HodnotaString))
                Directory.CreateDirectory(HodnotaString);

            // Přehled k souboru...
            string fileName = string.Format("{0}_{1}.txt", knihovnaJazyk.Text_PrehledTextu(7),
                DateTime.Now.ToString("yyyy_MM_dd_hh_mm_ss"));
            StreamWriter streamWriter = new StreamWriter(string.Format(@"{0}\{1}", HodnotaString,
                fileName));

            if (HodnotaBool)
                Text_SouborInfoChyba = fileName;

            // Uložení Souboru...
            streamWriter.Write(Get_InfoChyba);
            streamWriter.Close();
        }

        private void Funkce_SpusteniOkna()
        {
            Application.Run(knihovnaOkna.Okno_PrehledSpusteni(0));
        }
    }
}
