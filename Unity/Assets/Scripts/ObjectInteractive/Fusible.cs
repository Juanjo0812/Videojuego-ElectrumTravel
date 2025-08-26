using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fusible : MonoBehaviour
{

    public GameObject hide;
    public GameObject fusibleVerde;
    public Animator fusible;

    public GameObject text;

    public Toggle fusibleCheck;
    public Toggle fusibleVerdeCheck;

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
        fusible.Play("Coger");
        take = true;
        Invoke("Hide",2.7f);
    }
    
    public void Poner()
    {
        hide.SetActive(true);
        
        Fusible verify = hide.GetComponent<Fusible>();
        
        if (verify.take == true)
        {
            fusible.Play("Poner");
            put = true;
            Collider fusibleCollider = hide.GetComponent<Collider>();
            fusibleCollider.enabled = false;
            fusibleVerde.SetActive(false);
            fusibleVerdeCheck.isOn = true;

        }
        else
        {
            text.SetActive(true);
            Invoke("HideText",3);
        }
        
    }


    void Hide()
    {
        fusibleCheck.isOn = true;
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
