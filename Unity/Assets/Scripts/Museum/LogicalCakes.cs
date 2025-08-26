using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogicalCakes : MonoBehaviour
{
    public LogicalCharacter cakesCharacter;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        cakesCharacter.jumpEnabler = true;
    }

    private void OnTriggerExit(Collider other)
    {
        cakesCharacter.jumpEnabler = false;
    }
}
