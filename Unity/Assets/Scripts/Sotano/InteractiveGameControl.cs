using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveGameControl : MonoBehaviour
{
    public GameObject canvas;

    public GameObject palanca;
    public GameObject player;
    public GameObject museo;
    public GameObject gameControl;
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
        Collider palancaCollider = palanca.GetComponent<Collider>();
        palancaCollider.enabled = true;
        canvas.SetActive(false);
        player.SetActive(false);
        museo.SetActive(false);
        vitrina.SetActive(false);
        number.SetActive(true);
        gameControl.SetActive(true);
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
