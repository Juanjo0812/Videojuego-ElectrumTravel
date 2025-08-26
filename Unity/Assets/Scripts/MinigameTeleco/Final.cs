using UnityEngine;
using UnityEngine.UI;

public class Final : MonoBehaviour
{
    public AudioSource winSound;
    public Music gameManager;
    public GameObject canvasFinal;

    public GameObject player;
    public GameObject museo;
    public GameObject gameTeleco;

    public GameObject text;

    public GameObject HUDsotano;
    
    public void Posicion()
    {
        transform.position = new Vector3(1, 1, 1); //Aqui ponemos la posicion donde queremos que aparezca de nuevo.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasFinal.SetActive(true);
            gameManager.StopBackgroundMusic();
            winSound.Play();
            Debug.Log("Ganaste!");
        }
    }

    public void ChangeScene()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        
        player.SetActive(true);
        museo.SetActive(true);
        gameTeleco.SetActive(false);
        text.SetActive(true);
        HUDsotano.SetActive(true);
        
    }
}
