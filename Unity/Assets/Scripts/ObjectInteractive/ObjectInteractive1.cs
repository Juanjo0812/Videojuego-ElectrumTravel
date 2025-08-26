using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractive1 : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Ajusta la velocidad según sea necesario
    private bool armarioMovido = false;
    

    void Start()
    {
    }

    public void slide()
    {
        // Verifica si la tecla deseada está siendo presionada y si el armario no ha sido movido todavía
        if (!armarioMovido)
        {
            // Mueve el armario hacia arriba (puedes ajustar el vector de dirección según tus necesidades)
            Vector3 nuevaPosicion = transform.position + Vector3.left * 2.5f; // Ajusta la distancia según sea necesario
            StartCoroutine(MoverArmarioCoroutine(nuevaPosicion));
            armarioMovido = true;
            // Marca el armario como movido para que no se mueva más
        }

    }

    // Corrutina para controlar el movimiento suave del armario
    IEnumerator MoverArmarioCoroutine(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destino, velocidadMovimiento * Time.deltaTime);
            yield return null;
        }
        gameObject.SetActive(false);
    }
    
}

/*public bool doorOpen = false;
    public float angleOpen = 95f;
    public float angleClose = 0.0f;
    public float speed = 3.0f;

    public void ChangeDoorState()
    {
        doorOpen = !doorOpen;
    }
    void Update()
    {
        if (doorOpen)
        {
            Quaternion targetRotation3 = Quaternion.Euler(0, 0, angleOpen);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation3, speed * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation4 = Quaternion.Euler(0, 0, angleClose);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation4, speed * Time.deltaTime);
        }
    }*/
