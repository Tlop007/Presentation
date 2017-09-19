// Microsoft
using System;
using System.Windows.Forms;

// Aplikace
using Aplikace.Knihovny;

// Client
using Client.Knihovny;

namespace Aplikace
{
    static class Program
    {
        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Private - Void:
        //Static:
        [STAThread]
        static void Main()
        {
            Knihovna_Spusteni.Funkce_SpusteniOkna("Client", "Server");
        }

        public static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Knihovna_Okna.Okno_ZakladSpusteni());
        }
    }
}
