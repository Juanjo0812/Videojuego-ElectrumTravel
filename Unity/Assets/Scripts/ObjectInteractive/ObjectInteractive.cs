using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractive : MonoBehaviour
{
    public bool doorOpen = false;
    public float angleOpen = 95f;
    public float angleClose = 0.0f;
    public float speed = 3.0f;
    
    public void ChangeDoorState()
    {
        doorOpen = !doorOpen;
    }
    
    
    private void Update()
    {
        if (doorOpen)
        {
            Quaternion targetRotation = Quaternion.Euler(0, angleOpen, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, speed * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, angleClose, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, speed * Time.deltaTime);
        }
    }
}