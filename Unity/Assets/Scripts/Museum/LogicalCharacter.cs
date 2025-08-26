using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class LogicalCharacter : MonoBehaviour
{
    public float vMove= 5.0f;
    public float vRote = 200.0f;
    
    private Animator anim;
    public float x,y;

    public Rigidbody rb;
    public float jumpIntensity = 8f;
    public bool jumpEnabler;

    public GameObject cam1;
    public GameObject cam2;
    private bool campp = false;

    // Start is called before the first frame update
    void Start()
    {
        jumpEnabler = false;
        anim = GetComponent<Animator>();
        cam1.SetActive(campp);
        cam2.SetActive(!campp);
    }

    void FixedUpdate()
    {
        transform.Rotate(0,x*Time.deltaTime* vRote,0);
        transform.Translate(0,0,y*Time.deltaTime* vMove);
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y= Input.GetAxis("Vertical");

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);

        if (Input.GetKeyDown(KeyCode.F))
        {

            Camera();
            
            
        }

        if (jumpEnabler)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                anim.SetBool("Jump", true);
                rb.AddForce(new Vector3(0,jumpIntensity,0),ForceMode.Impulse);
            }
            anim.SetBool("GroundCollider", true);
        }
        else
        {
            Falling();
        }
    }

    void Camera()
    {
        campp = !campp;
        cam1.SetActive(!campp);
        cam2.SetActive(campp);
    }

    public void Falling()
    {
        anim.SetBool("GroundCollider", false);
        anim.SetBool("Jump", false);
    }
}
