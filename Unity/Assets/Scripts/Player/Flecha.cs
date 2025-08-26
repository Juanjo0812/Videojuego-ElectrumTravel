using UnityEngine;

public class Flecha : MonoBehaviour
{
    public Transform target; // El objetivo al que debe apuntar la flecha
    public float rotationSpeed = 10f; // Velocidad de rotación de la flecha
    public Vector3 offsetRotation = new Vector3(0f, -90f, 0f); // Rotación adicional para ajustar la orientación de la flecha

    void Update()
    {
        // Asegúrate de que el objetivo esté definido
        if (target != null)
        {
            // Calcula la dirección hacia el objetivo y normaliza
            Vector3 direction = (target.position - transform.position).normalized;

            // Aplica la rotación adicional para ajustar la orientación de la flecha
            Quaternion additionalRotation = Quaternion.Euler(offsetRotation);

            // Rota la flecha para que apunte hacia el objetivo
            if (direction != Vector3.zero)
            {
                Quaternion targetRotation = Quaternion.LookRotation(direction) * additionalRotation;
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
        }
    }
}


