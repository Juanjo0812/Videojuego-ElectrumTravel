using UnityEngine;

public class Info : MonoBehaviour
{
    public GameObject canvasConImagen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasConImagen.SetActive(true); // Activa el Canvas cuando ocurra la colisión
        }
    }

    public void CerrarCanvas()
    {
        canvasConImagen.SetActive(false); // Desactiva el Canvas cuando se presione el botón
    }
}
