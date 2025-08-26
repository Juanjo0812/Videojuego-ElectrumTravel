using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingTone : MonoBehaviour
{

    public AudioSource audio;

    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audio.Play();
            canvas.SetActive(true);
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
