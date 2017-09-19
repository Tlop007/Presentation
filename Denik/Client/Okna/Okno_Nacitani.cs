// Microsoft
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

// Client
using Client.Knihovny;
using Client.Knihovny.Rozdeleni;

// Server
using s = Server.Knihovny;

namespace Client.Okna
{
    public partial class Okno_Nacitani : Form
    {
        //Private - Knihovna_Jazyk:
        private Knihovna_Jazyk knihovnaJazyk;

        //Private - Knihovna_Chyba:
        private Knihovna_Chyba knihovnaChyba;

        //Private - Knihovna_SQL:
        private s.Knihovna_SQL knihovnaSQL;

        //Private - Knihovna_SQLPrikaz:
        private Knihovna_SQLPrikaz knihovnaSqlPrikaz;

        //Private - Knihovna_InfoAplikace:
        private Knihovna_InfoAplikace knihovnaInfoAplikace;

        //Private - Knihovna_Okna:
        private Knihovna_Okna knihovnaOkna;

        //Private - DataTable:
        private DataTable dtDenik;

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Okno_Nacitani()
        {
            InitializeComponent();
            Funkce_VedlejsiNastaveni();
        }

        private void Okno_Nacitani_Shown(object sender, EventArgs e)
        {
            Funkce_Nacteni();
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
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

            Text = string.Format("{0} - {1}", knihovnaJazyk.Text_PrehledTextu(5), knihovnaJazyk.Text_PrehledTextu(10));
            label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(13);
            Application.DoEvents();
        }

        private void Funkce_Nacteni()
        {
            try
            {
                label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(12);
                Application.DoEvents();

                dtDenik = knihovnaSQL.Get_Data(string.Format("{0} {1}", knihovnaSqlPrikaz.Text_PrehledPrikazu(1), knihovnaInfoAplikace.GetSet_IDUzivatel));

                if (dtDenik == null)
                {
                    knihovnaChyba.Funkce_VyhlaseniChyby(this);
                    return;
                }

                label_InfoText.Text = knihovnaJazyk.Text_PrehledTextu(11);
                Application.DoEvents();

                for (int i = 0; i < dtDenik.Rows.Count; i++)
                    // [0] - IDDenik; [1] - Text; [2] - Date;
                    knihovnaInfoAplikace.GetSet_Deniky.Add(new Rozdeleni_Denik(dtDenik.Rows[i][0].ToString(), dtDenik.Rows[i][1].ToString(), dtDenik.Rows[i][2].ToString()));

                // Otevření nového okna...
                Thread th = new Thread(Funkce_SpusteniOkna);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();

                Close();
            }
            catch (Exception ex)
            {
                knihovnaChyba.Set_InfoChyba = ex.ToString();
                knihovnaChyba.Funkce_VyhlaseniChyby(this);
            }
        }

        private void Funkce_SpusteniOkna()
        {
            Application.Run(knihovnaOkna.Okno_PrehledSpusteni(2));
        }
    }
}
