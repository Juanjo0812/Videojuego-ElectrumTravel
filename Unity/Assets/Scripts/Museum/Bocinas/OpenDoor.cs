using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{

    public bool open = false;

    public AudioSource audio;

    public GameObject text;
    
    public float rotationSpeed = 30f;
    public float floatAmount = 0.5f;
    private Vector3 startPosition;
    
    public Toggle digitales;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            digitales.isOn = true;
            open = true;
            text.SetActive(true);
            audio.Play();
            Collider bocina = gameObject.GetComponent<Collider>();
            bocina.enabled = false;
            Invoke("Cerrar",85);
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
