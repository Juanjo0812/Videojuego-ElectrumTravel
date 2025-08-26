using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    
    public Rigidbody rb;
    
    
    public float up = 100;

    public AudioSource fondo;
    void Start()
    {
        fondo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0,up*Time.deltaTime,0);
        }
    }

}
