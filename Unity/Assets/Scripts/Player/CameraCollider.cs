using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollider : MonoBehaviour
{
    private float minDistance = 1;
    private float maxDistance = 3;
    private float smoothness = 10;
    private float distance;

    Vector3 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        direction = transform.localPosition.normalized;
        distance = transform.localPosition.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posCamera = transform.parent.TransformPoint(direction * maxDistance);

        RaycastHit hit;

        if (Physics.Linecast(transform.parent.position, posCamera, out hit))
        {
            distance = Mathf.Clamp(hit.distance * 0.85f, minDistance, maxDistance);
        }
        else
        {
            distance = maxDistance;
        }
        transform.localPosition = Vector3.Lerp(transform.localPosition, direction * distance, smoothness * Time.deltaTime);
    }
}
