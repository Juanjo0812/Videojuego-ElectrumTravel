using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuadros : MonoBehaviour
{

    public GameObject cuadro1;
    public GameObject cuadro2;
    public GameObject cuadro3;
    public GameObject cuadro4;
    public GameObject cuadro5;
    public GameObject cuadro6;
    public GameObject cuadro7;
    public GameObject cuadro8;
    public GameObject cuadro9;
    public GameObject cuadro10;
    public GameObject cuadro11;
    public GameObject cuadro12;
    public GameObject cuadro13;
    public GameObject cuadro14;
    public GameObject cuadro15;
    public GameObject cuadro16;
    
    public GameObject fondo;
    public GameObject texto;


    
    // Start is called before the first frame update
    void Start()
    {
        cuadro1.SetActive(false);
        cuadro2.SetActive(false);
        cuadro3.SetActive(false);
        cuadro4.SetActive(false);
        cuadro5.SetActive(false);
        cuadro6.SetActive(false);
        cuadro7.SetActive(false);
        cuadro8.SetActive(false);
        cuadro9.SetActive(false);
        cuadro10.SetActive(false);
        cuadro11.SetActive(false);
        cuadro12.SetActive(false);
        cuadro13.SetActive(false);
        cuadro14.SetActive(false);
        cuadro15.SetActive(false);
        cuadro16.SetActive(false);
        fondo.SetActive(false);
        texto.SetActive(false);
        
    }
    
    public void Cuadro1()
    {
        texto.SetActive(true);
        cuadro1.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro2()
    {
        texto.SetActive(true);
        cuadro2.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro3()
    {
        texto.SetActive(true);
        cuadro3.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro4()
    {
        texto.SetActive(true);
        cuadro4.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro5()
    {
        texto.SetActive(true);
        cuadro5.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro6()
    {
        texto.SetActive(true);
        cuadro6.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro7()
    {
        texto.SetActive(true);
        cuadro7.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro8()
    {
        texto.SetActive(true);
        cuadro8.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro9()
    {
        texto.SetActive(true);
        cuadro9.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro10()
    {
        texto.SetActive(true);
        cuadro10.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro11()
    {
        texto.SetActive(true);
        cuadro11.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro12()
    {
        texto.SetActive(true);
        cuadro12.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro13()
    {
        texto.SetActive(true);
        cuadro13.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro14()
    {
        texto.SetActive(true);
        cuadro14.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro15()
    {
        texto.SetActive(true);
        cuadro15.SetActive(true);
        fondo.SetActive(true);
    }
    
    public void Cuadro16()
    {
        texto.SetActive(true);
        cuadro16.SetActive(true);
        fondo.SetActive(true);
    }

    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            texto.SetActive(false);
            cuadro1.SetActive(false);
            cuadro2.SetActive(false);
            cuadro3.SetActive(false);
            cuadro4.SetActive(false);
            cuadro5.SetActive(false);
            cuadro6.SetActive(false);
            cuadro7.SetActive(false);
            cuadro8.SetActive(false);
            cuadro9.SetActive(false);
            cuadro10.SetActive(false);
            cuadro11.SetActive(false);
            cuadro12.SetActive(false);
            cuadro13.SetActive(false);
            cuadro14.SetActive(false);
            cuadro15.SetActive(false);
            cuadro16.SetActive(false);
            fondo.SetActive(false);
        }
    }
}
