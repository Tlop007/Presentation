// Microsoft
using System;
using System.Windows.Forms;

// Client
using Client.Knihovny;

namespace Client.Okna
{
    public partial class Okno_Denik : Form
    {
        //Private - Knihovna_Jazyk:
        private Knihovna_Jazyk knihovnaJazyk;

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Okno_Denik()
        {
            InitializeComponent();
            Funkce_VedlejsiNastaveni();
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Private - Void:
        private void Funkce_VedlejsiNastaveni()
        {
            // Aplikování textu...
            knihovnaJazyk = new Knihovna_Jazyk();

            Text = knihovnaJazyk.Text_PrehledTextu(5);
        }
    }
}
