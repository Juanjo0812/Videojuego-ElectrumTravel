using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;
using UnityEngine.SceneManagement;

public class BallObjetive : MonoBehaviour
{
    
    
    
    private int score;

    public GameObject player;
    
    public GameObject museo;

    public GameObject gameControl;
    
    public GameObject canvasControls;

    public GameObject canvasScore;

    public GameObject canvasFinish;

    public GameObject text;

    public GameObject HUDsotano;

    public Text scoreText;
    
    public float minY = -22.5f;
    public float maxY = 22.5f;

    // Tiempo entre cambios de posición
    public float timeBetweenMoves = 5f;

    // Referencia al objeto que se moverá
    public Transform objectToMove;
    // Start is called before the first frame update
    void Start()
    {
        canvasFinish.SetActive(false);
        canvasScore.SetActive(false);
        score = 0;
        scoreText.text = "Score: " + score;
        
        
    }
    

    private void Score()
    {
        score++;
        scoreText.text = "Score: " + score;

        if (score == 500)
        {
            canvasFinish.SetActive(true);
        }
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Score();
        }
    }
    
    
    IEnumerator MoveObjectRandomly()
    {
        while (true)
        {
            // Genera una nueva posición aleatoria dentro del rango
            float newY = Random.Range(minY, maxY);
            Vector3 newPosition = new Vector3(0f, newY, 0f);

            // Aplica la nueva posición al objeto
            objectToMove.position = newPosition;

            // Espera el tiempo especificado antes de repetir el proceso
            yield return new WaitForSeconds(timeBetweenMoves);
        }
    }
    
    public void Canvas()
    {
        
        canvasControls.SetActive(false);
        canvasScore.SetActive(true);
        StartCoroutine(MoveObjectRandomly());
        
    }

    public void ChangeScene()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        player.SetActive(true);
        museo.SetActive(true);
        gameControl.SetActive(false);
        text.SetActive(true);
        HUDsotano.SetActive(true);
        
    }

}
