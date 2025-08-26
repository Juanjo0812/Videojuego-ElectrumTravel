using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    public Transform puntoInicial; // Punto inicial de la plataforma
    public Transform puntoFinal; // Punto final de la plataforma
    public float velocidad = 2.0f; // Velocidad de movimiento de la plataforma

    private Vector3 objetivo; // Posición objetivo hacia donde se moverá la plataforma

    private Vector3 posicionAnterior; // Posición anterior de la plataforma

    void Start()
    {
        // Configura la posición inicial de la plataforma
        transform.position = puntoInicial.position;
        objetivo = puntoFinal.position;
        posicionAnterior = transform.position;
    }

    void Update()
    {
        // Mueve la plataforma hacia el objetivo
        transform.position = Vector3.MoveTowards(transform.position, objetivo, velocidad * Time.deltaTime);

        // Si la plataforma alcanza el objetivo, cambia el objetivo
        if (Vector3.Distance(transform.position, objetivo) < 0.001f)
        {
            CambiarObjetivo();
        }

        // Guarda la posición actual como la posición anterior
        posicionAnterior = transform.position;
    }

    void CambiarObjetivo()
    {
        // Cambia el objetivo de la plataforma
        objetivo = (objetivo == puntoFinal.position) ? puntoInicial.position : puntoFinal.position;
    }

    public Vector3 PosicionAnterior
    {
        get { return posicionAnterior; }
    }
}