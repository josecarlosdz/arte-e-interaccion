using UnityEngine;

public class SceneMusicManager : MonoBehaviour
{
    public AudioClip sceneMusic; 
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        
        audioSource.clip = sceneMusic;
        audioSource.loop = true;        
        audioSource.playOnAwake = true; 
        audioSource.volume = 0.5f;      

        
        audioSource.Play();
    }
}
