using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAudios : MonoBehaviour
{

    public GameObject audioExterior;

    public GameObject gameComplete;

    public GameObject flecha;

    public GameObject text;

    public GameObject HUDmuseo;

    public int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerExit(Collider other)
    {
        USB verify = gameComplete.GetComponent<USB>();
        
        
        if (other.transform.CompareTag("Player"))
        {
            if (contador == 1)
            {
                audioExterior.SetActive(true);
                contador = 0;
            }
            else
            {
                HUDmuseo.SetActive(true);
                audioExterior.SetActive(false);
                contador++;   
            }

            if (verify.take == true)
            {
                flecha.SetActive(true);
                text.SetActive(false);
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
