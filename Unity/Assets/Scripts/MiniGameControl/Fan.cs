using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    // Velocidad de rotación en grados por segundo
    public float rotationSpeed = 360f;

    public AudioSource fan;

    // Update is called once per frame
    void Update()
    {
        // Si se presiona la tecla "a"
        if (Input.GetKey(KeyCode.Space))
        {
            
            // Obtener la rotación actual
            Quaternion currentRotation = transform.localRotation;

            // Calcular la rotación acumulada basada en la velocidad y el tiempo
            float rotationAmount = rotationSpeed * Time.deltaTime;

            // Aplicar la rotación acumulada al eje Y
            transform.localRotation = currentRotation * Quaternion.Euler(0, rotationAmount, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fan.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            fan.Stop();
        }
    }
}

