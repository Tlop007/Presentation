// Microsoft
using System;
using System.Windows.Forms;

// Client
using Client.Knihovny;

namespace Client.Okna
{
    public partial class Okno_Error : Form
    {
        //Private - Knihovna_Jazyk:
        private Knihovna_Jazyk knihovnaJazyk;

        //Private - Knihovna_Chyba:
        private Knihovna_Chyba knihovnaChyba;

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Okno_Error()
        {
            InitializeComponent();
            Funkce_VedlejsiNastaveni();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Close();
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Private - Void:
        private void Funkce_VedlejsiNastaveni()
        {
            // Aplikování textu...
            knihovnaJazyk = new Knihovna_Jazyk();
            knihovnaChyba = new Knihovna_Chyba();

            Text = string.Format("{0} - {1}", knihovnaJazyk.Text_PrehledTextu(5), knihovnaJazyk.Text_PrehledTextu(7));
            label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(8);
            label_Soubor.Text = knihovnaChyba.Get_SouborInfoChyba;
            richTextBox_Vypis.Text = knihovnaChyba.Get_InfoChyba;
        }
    }
}
