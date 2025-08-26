using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject component;
    
    private bool activated=false;

    private void Start()
    {
        
    }

    private void MyFunction()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {

            component.SetActive(true);
            audioSource.enabled = false;
            
            if (!activated)
            {
                activated = false;
                audioSource.enabled = true;
            }
        }
    }
}
