using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{

    private Vector3 initialPosition;
    
    public GameObject virus;
    
    public AudioSource explosion;

    private void Start()
    {
        // Guarda la posición inicial del robot al inicio
        initialPosition = GameObject.FindGameObjectWithTag("Player").transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            
            explosion.Play();
            // Restablece la posición del robot a la posición inicial
            other.transform.position = initialPosition;

            // Accede al Rigidbody y reinicia la velocidad
            Rigidbody playerRigidbody = other.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                playerRigidbody.velocity = Vector3.zero;
            }
            
            foreach (Transform child in virus.transform)
            {
                // Activa o desactiva el objeto hijo según el parámetro 'activar'
                child.gameObject.SetActive(true);
            }
        }
    }
    
}



