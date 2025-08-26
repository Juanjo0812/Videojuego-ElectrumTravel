using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyAccess : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectElectro;
    public GameObject objectControl;
    public GameObject objectTeleco;

    public GameObject exit;

    public GameObject player;
    public GameObject keypad;

    public GameObject text;

    public GameObject textSecurity;
    


    
    public void Entry()
    {

        Fusible verify1 = objectElectro.GetComponent<Fusible>();
        Palanca verify2 = objectControl.GetComponent<Palanca>();
        Modulador verify3 = objectTeleco.GetComponent<Modulador>();
        
        if ((verify1.take == true) && (verify2.take == true) && (verify3.take == true))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            player.SetActive(false);
            keypad.SetActive(true);
            exit.SetActive(true);
            text.SetActive(false);
        }
        else
        {
            textSecurity.SetActive(true);
            Invoke("CloseCanvas",4);
          
        }
    }

    void CloseCanvas()
    {
        textSecurity.SetActive(false);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            keypad.SetActive(false);
            player.SetActive(true);
            exit.SetActive(false);
        }
    }
}
