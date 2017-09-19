// Microsoft
using System.Collections.Generic;

// Unity
using UnityEngine;

public class Box_Controller : MonoBehaviour
{
    //Public - Int:
    public int pocetZamichani;

    //Public - AudioSource:
    public AudioSource clickSound;
    public AudioSource endSound;

    //Private - Int:
    private int moveCount;

    //Private - GameObject:
    /// <summary>
    /// Index 15 - Empty (Cube_16)
    /// </summary>
    private GameObject[] cube_Object;

    //Private - Vector:
    private Vector3[] cube_Historie;
    private Vector3 cube_EmptyPosition;

    //Private - Bool:
    private bool kontrolaMichani;

    //==========================================================================
    //===========================Hlavní Funkcionalita===========================
    //Private - Void:
    // Use this for initialization
    void Start()
    {
        Funkce_VytvoreniObjektu();
        Funkce_ProcesZamichani();
        kontrolaMichani = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Funkce_VypnutiHry();

        if (Sestava.Restart && !kontrolaMichani)
            Funkce_ProcesZamichani();

        if (Sestava.KonecHry)
            Funkce_PokracovaniHry();

        if (Sestava.Active && !Sestava.KonecHry)
            Funkce_ProcesAktivace(cube_Object[Sestava.Index].transform.localPosition.x,
                cube_Object[Sestava.Index].transform.localPosition.y);
    }

    //==========================================================================
    //==========================Vedlejší Funkcionalita==========================
    //Private -  Int:
    /// <summary>
    /// Vypsaní indexu objektu, ve které je zahrnuto mnoho kontrol, pro přesný index...
    /// </summary>
    /// <param name="x">Výskyt kliknutí pozice X</param>
    /// <param name="y">Výskyt kliknutí pozice Y</param>
    /// <param name="d">Přepočet pozice pro danou pozici X a Y</param>
    /// <param name="hodnotaBool">Kontroluje jestli je to pro pozici X (true), nebo Y (false)</param>
    /// <param name="kontrolaZnamenka">Kontroluje, jestli bylo zapojené znaménko '+', nebo '-'</param>
    /// <returns>Při objevení výsledku více než 16, je tendence k výskytu chyby (Což by nemělo vzniknout...)</returns>
    private int Set_Index(float x, float y, int d, bool hodnotaBool, float kontrolaZnamenka)
    {
        Vector3 uplatneniPozice = (hodnotaBool) ? new Vector3((kontrolaZnamenka == 1) ? x - d : x + d, y) : new Vector3(x, (kontrolaZnamenka == 1) ? y - d : y + d);

        for (int i = 0; i < cube_Object.Length; i++)
        {
            if (cube_Object[i].transform.localPosition == uplatneniPozice)
            {
                //Debug.Log(string.Format("Index - {0}", i));
                return i;
            }
        }

        return cube_Object.Length;
    }

    //Private - Void:
    /// <summary>
    /// Vytvoří základ objektu od zapnutí hry...
    /// </summary>
    private void Funkce_VytvoreniObjektu()
    {
        // Vytvoření objektu array, pro manipulaci objektů...
        cube_Object = new GameObject[transform.childCount];
        // Vytvoření objektu array, pro kontrolování základních pozic objektů...
        cube_Historie = new Vector3[transform.childCount];

        // Cyklus, který předává objekty do array objektu...
        for (int i = 0; i < transform.childCount; i++)
        {
            cube_Object[i] = transform.GetChild(i).gameObject;
            cube_Historie[i] = transform.GetChild(i).gameObject.transform.localPosition;
        }

        // Předání pozice empty, pro snadnejší manipulaci ve zdrojovém kódu...
        cube_EmptyPosition = cube_Object[15].transform.localPosition;
    }

    /// <summary>
    /// Aplikuje veškeré funkcionality, pro posun objektu...
    /// </summary>
    /// <param name="x">Výskyt kliknutí pozice X</param>
    /// <param name="y">Výskyt kliknutí pozice Y</param>
    private void Funkce_ProcesAktivace(float x, float y)
    {
        //Debug.Log(string.Format("X: {0}; Y: {1}", x, y));
        Sestava.Active = false;

        // Při stisknutí objektu, je vymezen této kontroly.
        // Teoreticky to funguje tak, že kde je umíštěn empty objekt, tak z toho bodu povolí z dané pozice X a Y.
        // Pro znázornění -                         = ˄ - Y
        if (x != cube_EmptyPosition.x && //         =
            y != cube_EmptyPosition.y)   //         =
            return;                      // =====(empty)=====       Kde není znaménko '=', tak kontrola vymezí k pokračování funkcionalitě...
                                         //         =       > - X
        Funkce_ProcesPosuvu(x, y, true); //         =
        Funkce_KontrolaKonce();          //         =
    }

    private void Funkce_ProcesPosuvu(float x, float y, bool score)
    {
        // Index 0 - počet posuvu o kolik se má posunout...
        // Index 1 - při vzniku hodnoty 1 (true) jde počet do mínusu a hodnota 0 (false) jde počet do plusu...
        int[] prepocetPoziceX = { (x > cube_EmptyPosition.x) ? (int)(x - cube_EmptyPosition.x) : (int)(cube_EmptyPosition.x - x), (x > cube_EmptyPosition.x) ? 1 : 0 };
        int[] prepocetPoziceY = { (y > cube_EmptyPosition.y) ? (int)(y - cube_EmptyPosition.y) : (int)(cube_EmptyPosition.y - y), (y > cube_EmptyPosition.y) ? 1 : 0 };

        // Vymezení empty pozice...
        if (prepocetPoziceX[0] == 0 && prepocetPoziceY[0] == 0)
            return;

        // Získání index objektu...
        #region Hledání indexu
        List<Rozpolozeni> _index = new List<Rozpolozeni>();
        if (prepocetPoziceX[0] > prepocetPoziceY[0])
        {
            for (int i = 0; i < prepocetPoziceX[0]; i++)
            {
                bool XY = true;
                _index.Add(new Rozpolozeni(Set_Index(x, y, i, XY, prepocetPoziceX[1]), XY, prepocetPoziceX[1]));
            }
        }
        else
        {
            for (int i = 0; i < prepocetPoziceY[0]; i++)
            {
                bool XY = false;
                _index.Add(new Rozpolozeni(Set_Index(x, y, i, XY, prepocetPoziceY[1]), XY, prepocetPoziceY[1]));
            }
        }
        #endregion

        // Pří získání indexu, se přes tuto metodu, aplikuje do objektu aby se synchronizoval...
        Funkce_ProcesAplikovani(_index);

        // cube_Object[15] nebo-li, cube_16 je prázné pole. Při jeho synchronizaci, je zapotřebí i cube_EmptyPosition, který je daný při kontrolovaní v metodách...
        cube_Object[15].transform.localPosition = new Vector3(x, y);
        cube_EmptyPosition = cube_Object[15].transform.localPosition;

        // Při aktivaci score režimu, spustí zvuk při kliknutí a a připočítává se, kolik kliknutí, nebo-li posuvu udělal...
        if (score)
        {
            clickSound.Play();
            moveCount++;
            Debug.Log(string.Format("Move - {0}", moveCount));
        }
    }

    /// <summary>
    /// Synchronizece objektů pro svá pozice...
    /// </summary>
    /// <param name="Index">List<Rozpolozeni> pro index, mělo by mít mnoho záznamů, pro uplatnění pozice</param>
    private void Funkce_ProcesAplikovani(List<Rozpolozeni> Index)
    {
        for (int i = 0; i < Index.Count; i++)
        {
            Vector3 uplatneniPozice = (Index[i].xY) ? new Vector3((Index[i].minusPlus == 1) ? cube_Object[Index[i].index].transform.localPosition.x - 1 : cube_Object[Index[i].index].transform.localPosition.x + 1, cube_Object[Index[i].index].transform.localPosition.y) :
                new Vector3(cube_Object[Index[i].index].transform.localPosition.x, (Index[i].minusPlus == 1) ? cube_Object[Index[i].index].transform.localPosition.y - 1 : cube_Object[Index[i].index].transform.localPosition.y + 1);

            cube_Object[Index[i].index].transform.localPosition = uplatneniPozice;
        }
    }

    /// <summary>
    /// Proces, který zamíchá objekty, do různých pozic...
    /// </summary>
    private void Funkce_ProcesZamichani()
    {
        System.Random ran = new System.Random();

        bool hodnotaBool_XY = false;
        float _x;
        float _y;

        for (int i = 0; i < pocetZamichani; i++)
        {
            // Je zde vypsaný Random, který umožňuje automaticky vytvořit číslo od 1 do 4.
            // Pokud se vytvoří náhodně číslo, ve které bude mít stejné číslo s empty pozicí, tak v další metodě, se aplikování indexu a synchronizace objektu, vymezí...
            // Např. - pokud se nastaví hodnota pocetZamichani na 100, tak počet aplikování může být odlišné a může se i snížit o 30 čísel dolů (Proto dávám v unity editoru hodnotu 100, aby se celkově zamíchali objekty).
            int randomCount = ran.Next(1, 5);

            // Toto umožňuje aby se pozice X a Y střídali po sobě...
            if (hodnotaBool_XY)
            {
                _x = cube_EmptyPosition.x;
                _y = randomCount;
            }
            else
            {
                _x = randomCount;
                _y = cube_EmptyPosition.y;
            }

            Funkce_ProcesPosuvu(_x, _y, false);
            hodnotaBool_XY = !hodnotaBool_XY;
        }

        // Zde se aktivuje bool pro vymezení znovu aplikování zamíchání, která vznikne při pokračování hry...
        kontrolaMichani = true;
    }

    /// <summary>
    /// Kontroluje, jestli objekty pozice jsou na správném místě...
    /// </summary>
    private void Funkce_KontrolaKonce()
    {
        if (moveCount < 0)
            return;

        for (int i = 0; i < cube_Historie.Length; i++)
        {
            if (cube_Object[i].transform.localPosition != cube_Historie[i])
                return;
        }

        // Pokud je správné pořadí, tak se přejde do metody, která aplikuje kontrolu...
        Funkce_KonecHry();
    }

    /// <summary>
    /// Aplikuje konec hry, pro znázornění k pokračování...
    /// </summary>
    private void Funkce_KonecHry()
    {
        Sestava.KonecHry = true;
        Sestava.PocetHer++;
        endSound.Play();
    }

    /// <summary>
    /// Aplikuje pokračování hry a zároveň obnoví veškeré proměnné pro novou hru...
    /// </summary>
    private void Funkce_PokracovaniHry()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Sestava.Active = false;
            Sestava.KonecHry = false;

            Sestava.ActiveFade = true;
            kontrolaMichani = false;
            Sestava.Restart = false;

            moveCount = 0;
        }
    }

    /// <summary>
    /// Kontroluje aktivaci tlačítka KeyCode.Escape pro ukončení celé hry, nebo-li aplikace...
    /// </summary>
    private void Funkce_VypnutiHry()
    {
        // Tuto funkcionalitu, jsem vyzkoušel ve Win7, kterou jsem testova při build této hry (Nevím jestli funguje i pro mobilní systémy).
        if (Input.GetKey(KeyCode.Escape))
            Application.Quit();
    }
}
