using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public GameObject canvasControls;

    public AudioSource shot;
    
    public AudioSource fondo;

    
        
    public Rigidbody rb;
    
    private float forward = 0;

    private float side = 0;
    // Start is called before the first frame update

    void Start()
    {
        fondo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.AddForce(0,0,forward*Time.deltaTime);
        

        if (Input.GetKey("d"))
        {
            rb.AddForce(side*Time.deltaTime,0,0);
        }
        
        if (Input.GetKey("a"))
        {
            rb.AddForce(-side*Time.deltaTime,0,0);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            shot.Play();
        }
        
    }

    public void Controls()
    {
        canvasControls.SetActive(false);
        forward = 200;
        side = 1200;
    }
    
}
