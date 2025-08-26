using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePositionCamera : MonoBehaviour
{
    public float Velocity = 100f;
    float RotationX = 0f;
    

    public Transform Player;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Velocity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Velocity * Time.deltaTime;

        RotationX -= mouseY;
        RotationX = Mathf.Clamp(RotationX, -90f, 90);
        
        transform.localRotation = Quaternion.Euler(RotationX, 0f, 0f);
        Player.Rotate(Vector3.up * mouseX);
        
    }
}
