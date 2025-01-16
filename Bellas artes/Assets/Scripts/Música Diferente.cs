using UnityEngine;

public class MusicChanger : MonoBehaviour
{
    public AudioClip newTrack; // Nueva canción para esta escena
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
