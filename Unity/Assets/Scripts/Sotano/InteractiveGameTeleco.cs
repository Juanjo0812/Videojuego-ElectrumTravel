using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveGameTeleco : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvas;

    public GameObject modulador;
    public GameObject player;
    public GameObject museo;
    public GameObject gameTeleco;
    public GameObject vitrina;
    public GameObject number;
    public GameObject text;
    
    public GameObject HUDsotano;
    void Start()
    {
        canvas.SetActive(false);
    }
    
    public void CanvasGame()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        canvas.SetActive(true);
    }

    
    public void ChangeGame()
    {
        Collider moduladorCollider = modulador.GetComponent<Collider>();
        moduladorCollider.enabled = true;
        canvas.SetActive(false);
        player.SetActive(false);
        museo.SetActive(false);
        vitrina.SetActive(false);
        number.SetActive(true);
        gameTeleco.SetActive(true);
        text.SetActive(false);
        HUDsotano.SetActive(false);
    }
    
    public void exit()
    {
        canvas.SetActive(false);
    }
    
    

    
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
