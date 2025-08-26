using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectedComp : MonoBehaviour
{
    public GameObject capacitor;
    public GameObject diodo;
    public GameObject inductor;
    public GameObject integrado;
    public GameObject resistencia;
    public GameObject transformador;
    public GameObject transistor;
    public GameObject canvasFinish;

    
    public GameObject player;
    public GameObject gameElectronica;
    public GameObject museo;
    public GameObject text;

    public GameObject HUDsotano;

    public AudioSource fondo;

    private int contador;
    
    // Start is called before the first frame update
    void Start()
    {
        fondo.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == capacitor)
        {
            contador++;
        }
        
        if (other.gameObject == diodo)
        {
            contador++;
        }
        
        if (other.gameObject == inductor)
        {
            contador++;
        }
        
        if (other.gameObject == integrado)
        {
            contador++;
        }
        
        if (other.gameObject == resistencia)
        {
            contador++;
        }
        
        if (other.gameObject == transformador)
        {
            contador++;
        }
        
        if (other.gameObject == transistor)
        {
            contador++;
        }
        Debug.Log(contador);
        
        if (contador >= 7)
        {
            Debug.Log("Ya no hay componentes dentro");
            Invoke("Delay", 2);
        }
    }
    
    public void ReturnScena()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        player.SetActive(true);
        museo.SetActive(true);
        gameElectronica.SetActive(false);
        text.SetActive(true);
        HUDsotano.SetActive(true);
    }

    void Delay()
    {
        canvasFinish.SetActive(true);
    }
}
