using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource audioSource; // Referencia al AudioSource
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); 
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        
        audioSource.Play();
        
    }
    public void StopBackgroundMusic()
    {
        audioSource.Stop();
    }

    public void Play()
    {
        audioSource.Play();
    }
}