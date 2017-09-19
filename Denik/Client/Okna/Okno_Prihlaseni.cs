// Microsoft
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

// Client
using Client.Knihovny;

// Server
using s = Server.Knihovny;

namespace Client.Okna
{
    public partial class Okno_Prihlaseni : Form
    {
        //Private - Knihovna_Jazyk:
        private Knihovna_Jazyk knihovnaJazyk;

        //Private - Knihovna_InfoAplikace:
        private Knihovna_InfoAplikace knihovnaInfoAplikace;

        //Private - Knihovna_SQL:
        private s.Knihovna_SQL knihovnaSQL;

        //Private - Knihovna_Chyba:
        private Knihovna_Chyba knihovnaChyba;

        //Private - Knihovna_SQLPrikaz:
        private Knihovna_SQLPrikaz knihovnaSqlPrikaz;

        //Private - Knihovna_Okna:
        private Knihovna_Okna knihovnaOkna;

        //Private - DataTable:
        private DataTable dtHeslo;

        #if DEBUG
        //Private - Bool:
        private bool rychleSpusteni = true;
        #endif

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Okno_Prihlaseni()
        {
            InitializeComponent();
            Funkce_VedlejsiNastaveni();
        }

        private void button_Prihlasit_Click(object sender, EventArgs e)
        {
            Funkce_Prihlaseni();
        }

        private void button_Zrusit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_Heslo_TextChanged(object sender, EventArgs e)
        {
            Funkce_VymezeniPrihlaseni();
        }

        private void Okno_Prihlaseni_Shown(object sender, EventArgs e)
        {
            #if DEBUG
            if (rychleSpusteni)
                Funkce_Prihlaseni();
            #endif
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Privatet - Bool:
        private bool Kontrola_PristupnostPrihlaseni()
        {
            return textBox_Heslo.TextLength > 0;
        }

        private bool Kontrola_Hesla(string HodnotaString)
        {
            #if DEBUG
            if (rychleSpusteni)
            {
                textBox_Heslo.Text = HodnotaString;
                Application.DoEvents();
                return true;
            }
            #endif

            return textBox_Heslo.Text == HodnotaString;
        }

        //Private - Void:
        private void Funkce_VedlejsiNastaveni()
        {
            knihovnaChyba = new Knihovna_Chyba();
            knihovnaSQL = new s.Knihovna_SQL();
            knihovnaSqlPrikaz = new Knihovna_SQLPrikaz();
            knihovnaOkna = new Knihovna_Okna();

            // Aplikování textu...
            knihovnaJazyk = new Knihovna_Jazyk();
            knihovnaInfoAplikace = new Knihovna_InfoAplikace();

            Text = string.Format("{0} - {1}", knihovnaJazyk.Text_PrehledTextu(5), knihovnaJazyk.Text_PrehledTextu(6));
            label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(2);
            label_Verze.Text = string.Format("{0} - {1}", knihovnaJazyk.Text_PrehledTextu(4), knihovnaInfoAplikace.Get_VerzeAplikace);

            // Aplikování funkcionalit...
            Funkce_VymezeniPrihlaseni();
        }

        private void Funkce_Prihlaseni()
        {
            Funkce_VymezeniPrihlasovani(true);
            dtHeslo = knihovnaSQL.Get_Data(knihovnaSqlPrikaz.Text_PrehledPrikazu(0));

            if (dtHeslo == null)
                Funkce_ZmenaTextuChyby(true);
            else
            {
                if (Kontrola_Hesla(dtHeslo.Rows[0][1].ToString()))
                {
                    // Zápis dat...
                    knihovnaInfoAplikace.GetSet_IDUzivatel = dtHeslo.Rows[0][0].ToString(); // ID uživatele...

                    // Otevření nového okna...
                    Thread th = new Thread(Funkce_SpusteniOkna);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                    Close();
                }
                else
                    Funkce_ZmenaTextuChyby(false);
            }
        }

        private void Funkce_VymezeniPrihlaseni()
        {
            if (Kontrola_PristupnostPrihlaseni())
                button_Prihlasit.Enabled = true;
            else
                button_Prihlasit.Enabled = false;

            if (label_Chyba.Visible == true)
                label_Chyba.Visible = false;
        }

        private void Funkce_ZmenaTextuChyby(bool HodnotaBool)
        {
            Funkce_VymezeniPrihlasovani(false);

            switch (HodnotaBool)
            {
                case true:
                    label_Chyba.Text = knihovnaJazyk.Text_PrehledTextu(1);
                    knihovnaChyba.Funkce_VyhlaseniChyby();
                    break;
                case false:
                    label_Chyba.Text = knihovnaJazyk.Text_PrehledTextu(0);
                    textBox_Heslo.Text = null;
                    break;
            }

            label_Chyba.Location = new Point(this.Size.Width - label_Chyba.Size.Width - 16, label_Chyba.Location.Y);
            label_Chyba.Visible = true;

            textBox_Heslo.Focus();
        }

        private void Funkce_VymezeniPrihlasovani(bool HodnotaBool)
        {
            if (HodnotaBool)
                label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(3);
            else
                label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(2);

            if (label_Chyba.Visible)
                label_Chyba.Visible = false;

            label_Heslo.Enabled = !HodnotaBool;
            textBox_Heslo.Enabled = !HodnotaBool;
            button_Prihlasit.Enabled = !HodnotaBool;
            button_Zrusit.Enabled = !HodnotaBool;

            Application.DoEvents();
        }

        private void Funkce_SpusteniOkna()
        {
            Application.Run(knihovnaOkna.Okno_PrehledSpusteni(1));
        }
    }
}
