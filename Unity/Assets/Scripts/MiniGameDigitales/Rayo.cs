using UnityEngine;

public class Disparo : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform puntoDisparo;
    public float alcance = 100f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparar();
        }
    }

    void Disparar()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 puntoFinal;

        if (Physics.Raycast(ray, out hit, alcance))
        {
            puntoFinal = hit.point;
        }
        else
        {
            puntoFinal = ray.origin + ray.direction * alcance;
        }

        RenderizarRayo(puntoDisparo.position, puntoFinal);
    }

    void RenderizarRayo(Vector3 origen, Vector3 destino)
    {
        lineRenderer.SetPosition(0, origen);
        lineRenderer.SetPosition(1, destino);
        lineRenderer.enabled = true;

        // Después de un corto tiempo, desactiva el rayo
        Invoke("DesactivarRayo", 0.04f);
    }

    void DesactivarRayo()
    {
        lineRenderer.enabled = false;
    }
}