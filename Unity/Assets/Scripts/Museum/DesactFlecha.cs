using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactFlecha : MonoBehaviour
{

    public GameObject flecha;

    public GameObject HUDcolocar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            flecha.SetActive(false);
            HUDcolocar.SetActive(true);
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
