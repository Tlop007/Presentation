// Unity
using UnityEngine;

public class Cube_Controller : MonoBehaviour
{
    public byte index;

    private void OnMouseDown()
    {
        // Získání informací, pro uplatnění do Box_Controller...
        Sestava.Index = index;
        Sestava.Active = true;
    }
}
