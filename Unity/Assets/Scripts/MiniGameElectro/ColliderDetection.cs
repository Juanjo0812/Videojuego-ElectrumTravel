using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ColliderDetection : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject component;
    public GameObject compSpectrum;
    public GameObject compComplete;

    private Vector3 posSpectrum;
    private bool activated = false;

    private void Start()
    {
        
    }

    private void MyFunction()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Soy el espectro, alguien ha entrado");

        component.SetActive(true);

        if (!activated)
        {
            //Debug.Log(component.tag);
            //Debug.Log(compSpectrum.tag);
            
            if (other.tag == compSpectrum.tag)
            {
                compSpectrum.SetActive(false);
                compComplete.SetActive(true);
                activated = true;
                audioSource.Play();
                component.SetActive(false);
            }
        }
    }
}
