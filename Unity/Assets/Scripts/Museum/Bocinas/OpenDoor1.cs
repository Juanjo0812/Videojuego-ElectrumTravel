using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UI.Toggle;

public class OpenDoor1 : MonoBehaviour
{

    public bool open = false;

    public AudioSource audio;
    
    public GameObject text;
    
    public float rotationSpeed = 30f;
    public float floatAmount = 0.5f;
    private Vector3 startPosition;

    public Toggle teleco;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            teleco.isOn = true;
            open = true;
            text.SetActive(true);
            audio.Play();
            Collider bocina = gameObject.GetComponent<Collider>();
            bocina.enabled = false;
            Invoke("Cerrar",93);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotar el objeto suavemente
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Flotar el objeto en bucle
        float newY = startPosition.y + Mathf.Sin(Time.time) * floatAmount;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            text.SetActive(false);
            audio.Stop();
            Collider bocina = gameObject.GetComponent<Collider>();
            bocina.enabled = true;
        }
    }
    
    void Cerrar()
    {
        text.SetActive(false);
        Collider bocina = gameObject.GetComponent<Collider>();
        bocina.enabled = true;
    }
}
