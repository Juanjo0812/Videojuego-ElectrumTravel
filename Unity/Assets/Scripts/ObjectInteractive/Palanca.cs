using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Palanca : MonoBehaviour
{
    public GameObject hide;
    public GameObject palancaVerde;
    public Animator palanca;
    
    public GameObject text;

    public Toggle palancaCheck;
    public Toggle palancaVerdeCheck;

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
        palanca.Play("Coger");
        take = true;
        Invoke("Hide",2.7f);
    }
    
    public void Poner()
    {
        hide.SetActive(true);
        
        Palanca verify = hide.GetComponent<Palanca>();
        
        if (verify.take == true)
        {
            palanca.Play("Poner");
            put = true;
            Collider palancaCollider = hide.GetComponent<Collider>();
            palancaCollider.enabled = false;
            palancaVerde.SetActive(false);
            palancaVerdeCheck.isOn = true;
        }
        else
        {
            text.SetActive(true);
            Invoke("HideText",3);
        }
        
    }
    
    void Hide()
    {
        palancaCheck.isOn = true;
        hide.SetActive(false);
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
