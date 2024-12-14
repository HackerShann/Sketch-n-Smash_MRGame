using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppManagerScript : MonoBehaviour
{
    public GameObject CurrentLeft;
    public GameObject CurrentRight;
    public GameObject TheDotL;
    public GameObject TheDotR;
    public GameObject TheLeftEdge;
    public GameObject TheRightEdge;
    public GameObject Leraser;
    public GameObject Reraser;

    private float ScaleChangeL;
    private float ScaleChangeR;

    private bool FirstDrawL = true;
    private bool FirstDrawR = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Left Side
        if (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) > 0 && FirstDrawL == true)
        {
            FirstDrawL = false;
            ScaleChangeL = (OVRInput.Get(OVRInput.RawAxis1D.LIndexTrigger) / 50f);
            CurrentLeft = Instantiate(TheDotL, TheLeftEdge.transform.position, TheLeftEdge.transform.rotation);
            CurrentLeft.transform.localScale = new Vector3(ScaleChangeL, ScaleChangeL, ScaleChangeL);
            FirstDrawL = true;
        }

        // Right side
        if (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) > 0 && FirstDrawR == true)
        {
            FirstDrawR = false;
            ScaleChangeR = (OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger) / 50f);
            CurrentRight = Instantiate(TheDotR, TheRightEdge.transform.position, TheRightEdge.transform.rotation);
            CurrentRight.transform.localScale = new Vector3(ScaleChangeR, ScaleChangeR, ScaleChangeR);
            FirstDrawR = true;
        }

        // Erasing

        if (OVRInput.Get(OVRInput.RawButton.LHandTrigger))
        {
            Leraser.SetActive(true);
        }

        else
        {
            Leraser.SetActive(false);
        }

        if (OVRInput.Get(OVRInput.RawButton.RHandTrigger))
        {
            Reraser.SetActive(true);
        }

        else
        {
            Reraser.SetActive(false);
        }

    }
}
