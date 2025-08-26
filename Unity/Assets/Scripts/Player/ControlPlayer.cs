using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    private CharacterController controller;
    private GameObject camera;
    
    private bool antenaActivated = false;

    [Header("Estadisticas Normales")] 
    [SerializeField] private float velocity;
    [SerializeField] private float runningSpeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private float turningTime;
    
    [Header("Datos sobre el piso")] 
    [SerializeField] private Transform detectFloor;
    [SerializeField] private float floorDistance;
    [SerializeField] private LayerMask floorMask;

    float turningSpeed;
    float gravity = -9.81f;
    private Vector3 speed;
    private bool touchFloor;

    private Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        
        controller = GetComponent<CharacterController>();
        camera = GameObject.FindGameObjectWithTag("MainCamera");
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        touchFloor = Physics.CheckSphere(detectFloor.position, floorDistance, floorMask);

        if (touchFloor && speed.y < 0)
        {
            speed.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && touchFloor)
        {
            speed.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        speed.y += gravity * Time.deltaTime;
        controller.Move(speed * Time.deltaTime);

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude <= 0)
        {
            anim.SetFloat("Movements", 0, 0.1f, Time.deltaTime);
        }

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + camera.transform.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turningSpeed, turningTime);
            transform.rotation = Quaternion.Euler(0, angle, 0);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                Vector3 move = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
                controller.Move(move.normalized * runningSpeed * Time.deltaTime);
                anim.SetFloat("Movements", 1f, 0.1f, Time.deltaTime);
            }
            else
            {
                Vector3 move = Quaternion.Euler(0, targetAngle, 0) * Vector3.forward;
                controller.Move(move.normalized * velocity * Time.deltaTime);
                anim.SetFloat("Movements", 0.5f, 0.1f, Time.deltaTime);
            }
        }
    }
    
    public void SetAntennaControl(bool control)
    {
        antenaActivated = control;

        // Desactivar el script de movimiento si está en control de la antena
        if (control)
        {
            // Desactiva el script de movimiento aquí
            // por ejemplo, desactiva el componente de script:
            GetComponent<ControlPlayer>().enabled = false;
        }
        else
        {
            // Activa el script de movimiento si no está en control de la antena
            // por ejemplo, activa el componente de script:
            GetComponent<ControlPlayer>().enabled = true;
        }
    }
}
