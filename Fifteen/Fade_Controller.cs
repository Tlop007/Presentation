using UnityEngine;

public class Fade_Controller : MonoBehaviour
{
    //Public - Float:
    public float rychlostFade;

    //==========================================================================
    //===========================Hlavní Funkcionalita===========================
    //Private - Void:
    // Use this for initialization
    void Start ()
    {
        // Úprava velikosti efektu...
        GetComponent<GUITexture>().pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Manipulace s efektem fade, při vzniku aktivace...
        if (Sestava.ActiveFade)
            Funkce_Start();
        else
            Funkce_End();
    }

    //==========================================================================
    //==========================Vedlejší Funkcionalita==========================
    //Private - Void:
    private void Funkce_FadeToClear()
    {
        // Barva která byl aplikována se změní na transparent podle časového pásma...
        GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.clear, Time.deltaTime * rychlostFade);
    }

    private void Funkce_FadeToColor()
    {
        // Transparent se změní na danou barvu podle časového pásma...
        GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.black, Time.deltaTime * rychlostFade);
    }

    /// <summary>
    /// Zapnutí Fade efektu...
    /// </summary>
    private void Funkce_Start()
    {
        Funkce_FadeToColor();

        // Zbytek který už není potřeba měnit, ale je pořád v pohybu, tak se vymezí pro resetování...
        if (GetComponent<GUITexture>().color.a >= 0.5)
        {
            GetComponent<GUITexture>().color = Color.black;
            Sestava.ActiveFade = false;
            Sestava.Restart = true;
        }
    }

    /// <summary>
    /// Vypnutí Fade efektu...
    /// </summary>
    private void Funkce_End()
    {
        Funkce_FadeToClear();

        // Zbytek který už není potřeba měnit, ale je pořád v pohybu, tak se vymezí pro resetování...
        if (GetComponent<GUITexture>().color.a <= 0.01)
        {
            GetComponent<GUITexture>().color = Color.clear;
        }
    }
}
