using UnityEngine;
using UnityEngine.UI;

public class RayCast : MonoBehaviour
{
    public GameObject infoCap;
    public GameObject infoDiodo;
    public GameObject infoIndu;
    public GameObject infoInte;
    public GameObject infoResis;
    public GameObject infoTransf;
    public GameObject infoTransi;
    
    void Update()
    {
        // Obtén la posición del puntero del mouse en el mundo
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Declara una variable para almacenar la información del impacto del rayo
        RaycastHit hit;

        // Realiza el raycast y verifica si ha golpeado algo
        if (Physics.Raycast(ray, out hit) && hit.collider.GetComponent<DragDrop>() == true && !Input.GetMouseButton(0))
        {
            // La variable 'hit' contiene la información sobre el objeto impactado
            //Debug.Log("Objeto impactado: " + hit.collider.gameObject.name);
            
            // Sentencias para activar el sprite de información para cada componente
            if (hit.collider.gameObject.name == "capacitor")
            {
                infoCap.SetActive(true);
            }

            if (hit.collider.gameObject.name == "diodo")
            {
                infoDiodo.SetActive(true);
            }
            
            if (hit.collider.gameObject.name == "inductor")
            {
                infoIndu.SetActive(true);
            }
            
            if (hit.collider.gameObject.name == "integrado")
            {
                infoInte.SetActive(true);
            }
            
            if (hit.collider.gameObject.name == "resistencia")
            {
                infoResis.SetActive(true);
            }
            
            if (hit.collider.gameObject.name == "transformador")
            {
                infoTransf.SetActive(true);
            }
            
            if (hit.collider.gameObject.name == "transistor")
            {
                infoTransi.SetActive(true);
            }
        }
        else
        {
            // Desactiva el sprite de información para cada componente cuando no se cumple la condición
            infoCap.SetActive(false);
            infoDiodo.SetActive(false);
            infoIndu.SetActive(false);
            infoInte.SetActive(false);
            infoResis.SetActive(false);
            infoTransf.SetActive(false);
            infoTransi.SetActive(false);
        }
    }
}