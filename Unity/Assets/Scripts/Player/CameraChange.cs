using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject camPP;
    public GameObject camTP;

    public GameObject body;

    private bool view;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            view = true;
        }
        
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            view = false;
        }

        if (view == true)
        {
            camPP.SetActive(true);
            camTP.SetActive(false);
            body.SetActive(false);
            GetComponent<OrbitalCameraFP>().enabled = true;
            GetComponent<OrbitalCamera>().enabled = false;
        }
        else
        {
            camPP.SetActive(false);
            camTP.SetActive(true);
            body.SetActive(true);
            GetComponent<OrbitalCameraFP>().enabled = false;
            GetComponent<OrbitalCamera>().enabled = true;
        }
    }
}
