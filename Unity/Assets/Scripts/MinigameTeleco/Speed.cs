using System.Collections;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public RobotFreeAnim robot;
    public float aumentoTemporal = 2.0f;
    public float tiempoTemporal = 3.0f;
    public AudioSource speed;
    private float velocidadOriginal; // Guarda el valor original de la velocidad


    void Start()
    {
        robot = FindObjectOfType<RobotFreeAnim>();
        velocidadOriginal = robot.vMove; // Guarda el valor original de la velocidad

    }
    
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entraste al modo turbo");
            if (robot != null)
            {
                StartCoroutine(VelocidadTemporal());
                robot.MovContinuo();
                speed.Play();
            }
            else
            {
                Debug.Log("No se encontro Robot en la escena...");
            }
        }

        IEnumerator VelocidadTemporal()
        {
            robot.AumentadorV(aumentoTemporal);
            yield return new WaitForSeconds(tiempoTemporal);
            robot.AumentadorV(-aumentoTemporal); // Reduzca la velocidad temporalmente
            yield return new WaitForSeconds(0.1f); // Asegura que la velocidad se reduzca antes de restablecerla
            robot.AumentadorV(velocidadOriginal); // Restablece la velocidad a su valor original
        }
    }
}