using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detected : MonoBehaviour
{

    public GameObject digitales;
    public GameObject teleco;
    public GameObject control;
    public GameObject electronica;

    private LayerMask mask;

    public float distance = 1.5f;

    public GameObject textDetect;
    public GameObject textDoor;
    
    private GameObject last = null;

    private Color originalColor;

    public GameObject HUDmuseo;

    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        textDetect.SetActive(false);
        textDoor.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            
            OpenDoor verify1 = digitales.GetComponent<OpenDoor>();
            OpenDoor1 verify2 = teleco.GetComponent<OpenDoor1>();
            OpenDoor2 verify3 = control.GetComponent<OpenDoor2>();
            OpenDoor3 verify4 = electronica.GetComponent<OpenDoor3>();
            



            if (hit.collider.tag == "Door")
            {
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                    
                    hit.collider.transform.GetComponent<ObjectInteractive>().ChangeDoorState();
                }
            }

            else if (hit.collider.tag == "Door1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<ObjectInteractive1>().slide();
                }
            }

            else if (hit.collider.tag == "Door2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if ((verify1.open == true) && (verify2.open == true) && (verify3.open == true) && (verify4.open == true))
                    { 
                        Destroy(HUDmuseo);
                        hit.collider.transform.GetComponent<ObjectInteractive>().ChangeDoorState();
                    }
                    else
                    {
                        textDoor.SetActive(true);
                        Invoke("CloseCanvas",4);
                    }
                }
                
            }

            else if (hit.collider.tag == "Shelf")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Shelf>().slide();
                }
            }

            else if (hit.collider.tag == "Phone")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Phone>().Audio();
                }
            }

            else if (hit.collider.tag == "GameMuseum")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<ChangeMuseum>().ChangeGame();
                }
            }

            else if (hit.collider.tag == "GameDigitales")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<InteractiveGameDigitales>().CanvasGame();
                }
            }

            else if (hit.collider.tag == "GameControl")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<InteractiveGameControl>().CanvasGame();
                }
            }

            else if (hit.collider.tag == "GameElectro")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<InteractiveGameElectro>().CanvasGame();
                }
            }

            else if (hit.collider.tag == "GameTeleco")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<InteractiveGameTeleco>().CanvasGame();
                }
            }

            else if (hit.collider.tag == "Cuadro1")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro1();
                }
            }

            else if (hit.collider.tag == "Cuadro2")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro2();
                }
            }

            else if (hit.collider.tag == "Cuadro3")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro3();
                }
            }

            else if (hit.collider.tag == "Cuadro4")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro4();
                }
            }

            else if (hit.collider.tag == "Cuadro5")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro5();
                }
            }

            else if (hit.collider.tag == "Cuadro6")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro6();
                }
            }

            else if (hit.collider.tag == "Cuadro7")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro7();
                }
            }

            else if (hit.collider.tag == "Cuadro8")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro8();
                }
            }
            
            else if (hit.collider.tag == "Cuadro9")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro9();
                }
            }
            
            else if (hit.collider.tag == "Cuadro10")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro10();
                }
            }
            
            else if (hit.collider.tag == "Cuadro11")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro11();
                }
            }
            
            else if (hit.collider.tag == "Cuadro12")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro12();
                }
            }
            
            else if (hit.collider.tag == "Cuadro13")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro13();
                }
            }
            
            else if (hit.collider.tag == "Cuadro14")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro14();
                }
            }
            
            else if (hit.collider.tag == "Cuadro15")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro15();
                }
            }
            
            else if (hit.collider.tag == "Cuadro16")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Cuadros>().Cuadro16();
                }
            }
            
            else if (hit.collider.tag == "Fusible")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Fusible>().Coger();
                }
            }
            
            else if (hit.collider.tag == "Palanca")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Palanca>().Coger();
                }
            }
            
            else if (hit.collider.tag == "Modulador")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Modulador>().Coger();
                }
            }
            
            else if (hit.collider.tag == "USB")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<USB>().Coger();
                }
            }
            
            
            else if (hit.collider.tag == "Security")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<KeyAccess>().Entry();
                }
            }
            
            else if (hit.collider.tag == "Switch")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Switch>().Interact();
                }
            }
            
            else if (hit.collider.tag == "FusibleVerde")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Fusible>().Poner();
                }
            }
            
            else if (hit.collider.tag == "PalancaVerde")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Palanca>().Poner();
                }
            }
            
            else if (hit.collider.tag == "ModuladorVerde")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Modulador>().Poner();
                }
            }
            
            else if (hit.collider.tag == "USBVerde")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<USB>().Poner();
                }
            }
            
            
            
        }
        
        else 
        {
            Deselect();
        } 
        
    }


    void SelectedObject(Transform transform)
    {
        if (last != transform.gameObject)
        {
            // Restaurar el objeto anterior antes de seleccionar uno nuevo
            Deselect();
        }

        originalColor = transform.GetComponent<Renderer>().material.color;

        // Cambiar el color al seleccionar
        transform.GetComponent<Renderer>().material.color = Color.grey;

        last = transform.gameObject;
    }

    void Deselect()
    {
        if (last)
        {
            last.GetComponent<Renderer>().material.color = originalColor;
            last = null;
        }
    }

    void OnGUI()
    {
        if (last)
        {
            textDetect.SetActive(true);
        }
        else
        {
            textDetect.SetActive(false);
        }
    }

    void CloseCanvas()
    {
        textDoor.SetActive(false);
    }

}

