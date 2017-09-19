// Microsoft
using System;
using System.Data;
using System.Data.SqlServerCe;

namespace Server.Knihovny
{
    public class Knihovna_SQL
    {
        //Private - Knihovna_Chyba:
        private Knihovna_Chyba knihovnaChyba;

        //Private - String:
        private string Text_SQLPripojeni { get; set; }

        //======================================================================================
        //=================================Hlavní Funkcionalita=================================
        //Public - Konstruktor:
        public Knihovna_SQL()
        {
            knihovnaChyba = new Knihovna_Chyba();
            Text_SQLPripojeni = @"Data Source=soubory\DB.sdf;Password=(heslo);Persist Security Info=True";
        }

        //======================================================================================
        //================================Vedlejší Funkcionalita================================
        //Public - String:
        /// <summary>
        /// Zjištění, který SQL příkaz pro připojení do databáze byl implementován...
        /// </summary>
        public string Get_SQLPripojeni
        {
            get
            {
                return Text_SQLPripojeni;
            }
        }

        //Public - DataTable:
        /// <summary>
        /// Získá potřebné data z databáze pře určitý příkaz...
        /// </summary>
        /// <param name="HodnotaString">Zde vypsat příkaz, který získá data</param>
        /// <returns>Pokud se vyskytne hodnota Null, to je známkou chyby</returns>
        public DataTable Get_Data(string HodnotaString)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCeConnection connect = new SqlCeConnection(Text_SQLPripojeni);
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(HodnotaString, connect);

                connect.Open();
                adapter.Fill(dt);
                connect.Close();

                return dt;
            }
            catch (Exception ex)
            {
                knihovnaChyba.Set_InfoChyba = ex.ToString();
                return null;
            }
        }

        //Public - Bool:
        /// <summary>
        /// Zapíše potřebné data do databáze přes určitý příkaz...
        /// </summary>
        /// <param name="HodnotaString">Zde vypsat příkaz, který zapíše data do databáze</param>
        /// <returns>Pokud se vyskytne hodnota False, to je známkou chyby</returns>
        public bool Set_Data(string HodnotaString)
        {
            try
            {
                SqlCeConnection connect = new SqlCeConnection(Text_SQLPripojeni);
                SqlCeCommand cmd = new SqlCeCommand(HodnotaString, connect);

                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();

                return true;
            }
            catch (Exception ex)
            {
                knihovnaChyba.Set_InfoChyba = ex.ToString();
                return false;
            }
        }
    }
}
