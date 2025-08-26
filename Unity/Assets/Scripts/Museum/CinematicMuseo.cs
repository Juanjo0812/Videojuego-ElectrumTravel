using System;
using System.Collections;
using UnityEngine;

public class CinematicMuseo : MonoBehaviour
{
    private int contador = 0;
    
    public GameObject player;
    
    public GameObject camPlayer;
    public GameObject camCinematic;
    public GameObject camMain;
    public GameObject text;
    public AudioSource audio;
    public AudioSource fondo;
    
    private Vector3 startPosition;

    private bool isCinematicActive = false;

    void Start()
    {
        camCinematic.SetActive(false);
        camMain.SetActive(false);
        text.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (contador == 0)
        {
            if (other.transform.CompareTag("Player"))
            {
                player.SetActive(false);
            
                audio.Play();
                fondo.Stop();
        
        
                text.SetActive(true);

                // Desactiva la cámara del jugador
                camPlayer.SetActive(false);

                // Activa la cámara cinematográfica
                camCinematic.SetActive(true);
                camMain.SetActive(true);

                contador++;
            
                Invoke("StopCinematic", 65);
                
            
            }
        }
        
        
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            contador = 0;
        }
    }


    void StopCinematic()
    {
        
        camCinematic.SetActive(false);
        camMain.SetActive(false);
        text.SetActive(false);
        
        fondo.Play();

        // Activa la cámara del jugador
        camPlayer.SetActive(true);
        
        player.SetActive(true);
        
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camCinematic.SetActive(false);
            camMain.SetActive(false);
            camPlayer.SetActive(true);
            text.SetActive(false);
            audio.Stop();
            fondo.Play();
            
            player.SetActive(true);
            
            CancelInvoke("StopCinematic");
        }
        
        
    }
}


