// Unity
using UnityEngine;

public class Draw_Controller : MonoBehaviour
{
    //Public - Float:
    public float newZ;
    public float rychlostPosuvu;

    //Private - Vector:
    private Vector3 historiDraw;

	// Use this for initialization
	void Start ()
    {
        historiDraw = this.GetComponent("Halo").transform.localPosition;
    }
	
	// Update is called once per frame
	void Update ()
    {
        // Manipulace s efektem Halo při vzniku konce hry...
        if (Sestava.KonecHry)
        {
            Vector3 vec = this.GetComponent("Halo").transform.localPosition;
            this.GetComponent("Halo").transform.localPosition = Vector3.Lerp(vec, new Vector3(historiDraw.x, historiDraw.y, newZ), Time.deltaTime * rychlostPosuvu);
        }
        else
            this.GetComponent("Halo").transform.localPosition = historiDraw;

    }
}
