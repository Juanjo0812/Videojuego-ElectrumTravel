using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class USB : MonoBehaviour
{

    public GameObject hide;
    public GameObject usbVerde;
    public Animator usb;
    
    public GameObject text;

    public GameObject antena;

    public Toggle usbCheck;
    public Toggle usbVerdeCheck;

    public GameObject HUDsotano;

    public bool take;
    public bool put;
    // Start is called before the first frame update
    
    void Start()
    {
        take = false;
        put = false;
    }
    
    public void Coger()
    {
        usb.Play("Coger");
        take = true;
        Invoke("Hide",2.7f);
    }
    
    public void Poner()
    {
        hide.SetActive(true);
        
        USB verify = hide.GetComponent<USB>();
        
        if (verify.take == true)
        {
            usb.Play("Poner");
            put = true;
            Collider usbCollider = hide.GetComponent<Collider>();
            usbCollider.enabled = false;
            usbVerde.SetActive(false);
            usbVerdeCheck.isOn = true;
        }
        else
        {
            text.SetActive(true);
            Invoke("HideText",3);
        }
        
    }
    
    void Hide()
    {
        usbCheck.isOn = true;
        hide.SetActive(false);
        Invoke("HideCheck", 2);
        
    }

    void HideCheck()
    {
        Destroy(HUDsotano);
        Invoke("ShowText", 1);
    }

    void ShowText()
    {
        antena.SetActive(true);
    }
    
    void HideText()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
