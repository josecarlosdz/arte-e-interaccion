using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    public AudioClip newTrack; 
    private AudioSource musicSource;

    void Start()
    {
        musicSource = FindObjectOfType<AudioSource>();

        if (musicSource != null && newTrack != null)
        {
            if (musicSource.clip != newTrack)
            {
                musicSource.clip = newTrack;
                musicSource.Play();
            }
        }
    }
}
