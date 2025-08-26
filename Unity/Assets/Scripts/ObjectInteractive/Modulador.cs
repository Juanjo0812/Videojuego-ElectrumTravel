using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modulador : MonoBehaviour
{

    public GameObject hide;
    public GameObject moduladorVerde;
    public Animator modulador;
    
    public GameObject text;

    public Toggle moduladorCheck;
    public Toggle moduladorVerdeCheck;

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
        modulador.Play("Coger");
        take = true;
        Invoke("Hide",2.7f);
    }
    
    public void Poner()
    {
        hide.SetActive(true);
        
        Modulador verify = hide.GetComponent<Modulador>();
        
        if (verify.take == true)
        {
            modulador.Play("Poner");
            put = true;
            Collider moduladorCollider = hide.GetComponent<Collider>();
            moduladorCollider.enabled = false;
            moduladorVerde.SetActive(false);
            moduladorVerdeCheck.isOn = true;
        }
        else
        {
            text.SetActive(true);
            Invoke("HideText",3);
        }
        
    }
    
    void Hide()
    {
        moduladorCheck.isOn = true;
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
