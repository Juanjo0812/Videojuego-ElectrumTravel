using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalCamera : MonoBehaviour
{
    [SerializeField] private Transform focus;
    [SerializeField] private float speedCamera = 120;
    [SerializeField] private float sensitivity = 150;

    private float mouseX;
    private float mouseY;
    private float rotY = 0;
    private float rotX = 0;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotY = rot.y;
        rotX = rot.x;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        rotY += mouseX * sensitivity * Time.deltaTime;
        rotX -= mouseY * sensitivity * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -60, 60);
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);
    }

    private void LateUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, focus.position, speedCamera * Time.deltaTime);
    }
}
