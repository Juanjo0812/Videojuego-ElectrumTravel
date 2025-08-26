using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelf : MonoBehaviour
{
    public float velocidadMovimiento = 5f; // Ajusta la velocidad según sea necesario
    public GameObject door;
    private bool armarioMovido = false;
    

    void Start()
    {
        Collider puertaCollider = door.GetComponent<Collider>();
        puertaCollider.enabled = false;
    }

    public void slide()
    {
        // Verifica si la tecla deseada está siendo presionada y si el armario no ha sido movido todavía
        if (!armarioMovido)
        {
            // Mueve el armario hacia arriba (puedes ajustar el vector de dirección según tus necesidades)
            Vector3 nuevaPosicion = transform.position + Vector3.forward * 5f; // Ajusta la distancia según sea necesario
            StartCoroutine(MoverArmarioCoroutine(nuevaPosicion));
            armarioMovido = true;
            Collider puertaCollider = door.GetComponent<Collider>();
            puertaCollider.enabled = true;
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
    }
       
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
