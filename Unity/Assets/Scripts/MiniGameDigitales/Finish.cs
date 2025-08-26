using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

    public GameObject player;
    
    public GameObject museo;

    public GameObject gameDigitales;

    public GameObject canvas;

    public GameObject text;

    public GameObject HUDsotano;
    
    
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player"))
        {
            
            canvas.SetActive(true);
            
        }
    }

    public void ChangeScene()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        player.SetActive(true);
        museo.SetActive(true);
        gameDigitales.SetActive(false);
        text.SetActive(true);
        HUDsotano.SetActive(true);
        
    }
}
