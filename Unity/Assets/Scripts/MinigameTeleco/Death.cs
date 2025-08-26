using UnityEngine;

public class Death : MonoBehaviour
{
    public Vector3 initialPosition;
    private bool confirmar = false;
    public GameObject canvasConImagen;
    public AudioSource audio;
    public Music music;
    public RobotFreeAnim robotfreeanim;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Suelo"))
        {
            canvasConImagen.SetActive(true);
            music.StopBackgroundMusic();
            audio.Play();
            if (confirmar = true)
            {
                Time.timeScale = 0f;
                robotfreeanim.Reset_player();
                transform.rotation = new Quaternion(0, -0.707106829f, 0, 0.707106829f);
                transform.position = initialPosition;
            }
        }
    }

    public void Si()
    {
        confirmar = true;
        Time.timeScale = 1f;
        music.Play();
        canvasConImagen.SetActive(false);
    }

}