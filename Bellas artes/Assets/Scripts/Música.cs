using UnityEngine;

public class SceneMusicManager : MonoBehaviour
{
    public AudioClip sceneMusic; // La canción que sonará en esta escena
    private AudioSource audioSource;

    void Start()
    {
        // Busca o crea un AudioSource en el objeto actual
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Configura el AudioSource
        audioSource.clip = sceneMusic;
        audioSource.loop = true;        // Para que la música se repita
        audioSource.playOnAwake = true; // La música comienza automáticamente
        audioSource.volume = 0.5f;      // Ajusta el volumen si es necesario

        // Reproduce la música
        audioSource.Play();
    }
}
