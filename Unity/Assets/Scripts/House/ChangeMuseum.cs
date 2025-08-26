using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeMuseum : MonoBehaviour
{

    public GameObject house;
    public GameObject museo;

    public void ChangeGame()
    {
        house.SetActive(false);
        museo.SetActive(true);
    }
    // Start is called before the first frame update
    
}
