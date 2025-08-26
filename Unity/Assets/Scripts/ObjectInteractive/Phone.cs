using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{

    public AudioSource audio;
    public AudioSource audioLlamada;

    public GameObject carro;

    public GameObject door;

    public GameObject canvas;
    // Start is called before the first frame update

    public void Audio()
    {
        audioLlamada.Play();
        audio.Stop();
        canvas.SetActive(false);
        Invoke("Carro",91);
    }
    
    void Start()
    {
        carro.SetActive(false);
    }


    void Carro()
    {
        
        carro.SetActive(true);
        door.layer = 6;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
