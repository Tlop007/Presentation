using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    //Public - Color:
    public Color32 color1;
    public Color32 color2;
    public Color32 color3;
    public Color32 color4;

    //Public - Float:
    public float newSize;
    public float rychlostPosuvu;

    //Private - Float:
    private float historiSize;

    private void Start()
    {
        historiSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update ()
    {
        // Manipulace s kamerou při vzniku konce hry...
        if (Sestava.KonecHry)
        {
            Camera.main.orthographicSize = Mathf.Lerp(Camera.main.orthographicSize, newSize, Time.deltaTime * rychlostPosuvu);
        }
        else
        {
            if (Sestava.Restart)
            {
                Camera.main.orthographicSize = historiSize;
                Funkce_ZmenaPozadi();
            }
        }
    }

    /// <summary>
    /// Systematické změny pozadí do barev...
    /// </summary>
    private void Funkce_ZmenaPozadi()
    {
        Color32[] sestavaBarev = { color1, color2, color3, color4 };
        Camera.main.backgroundColor = sestavaBarev[Sestava.PocetHer % 4];
    }
}
