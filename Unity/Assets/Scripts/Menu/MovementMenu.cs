using UnityEngine;

public class CameraPan : MonoBehaviour
{
    // Sensibilidad del movimiento del mouse
    public float sensitivity = 0.1f;

    // Limitar la rotación en los ejes X y Y
    public float maxYAngle = 80f;
    public float minYAngle = -80f;

    // Factor de suavizado
    public float smoothFactor = 5f;

    // Ángulo de rotación máximo permitido desde la orientación inicial
    private float maxAllowedRotation = 5f;

    // Almacena la rotación inicial de la cámara
    private Quaternion initialRotation;

    void Start()
    {
        // Guardar la rotación inicial de la cámara
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Obtener el movimiento del ratón
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calcular la rotación en función del movimiento del ratón
        Quaternion deltaRotation = Quaternion.Euler(-mouseY * sensitivity, mouseX * sensitivity, 0f);

        // Aplicar la rotación y limitarla en el eje Y
        Quaternion desiredRotation = ClampRotationAroundXAxis(initialRotation * deltaRotation);

        // Calcular la rotación total desde la orientación inicial
        float totalRotation = Quaternion.Angle(initialRotation, desiredRotation);

        // Limitar la rotación total a maxAllowedRotation
        if (totalRotation > maxAllowedRotation)
        {
            float t = maxAllowedRotation / totalRotation;
            desiredRotation = Quaternion.Lerp(initialRotation, desiredRotation, t);
        }

        // Aplicar la rotación suavizada a la cámara
        transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, smoothFactor * Time.deltaTime);
    }

    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        // Convertir la rotación a un ángulo de Euler
        Vector3 eulerAngle = q.eulerAngles;

        // Calcular el ángulo actual de rotación en el eje X
        float angleX = eulerAngle.x;

        // Ajustar el ángulo a [-180, 180]
        if (angleX > 180f)
            angleX -= 360f;

        // Calcular el rango de rotación permitido en el eje X
        float minAngle = minYAngle;
        float maxAngle = maxYAngle;

        // Clampear el ángulo dentro del rango permitido
        angleX = Mathf.Clamp(angleX, minAngle, maxAngle);

        // Retornar la rotación clamped
        return Quaternion.Euler(angleX, eulerAngle.y, eulerAngle.z);
    }
}
