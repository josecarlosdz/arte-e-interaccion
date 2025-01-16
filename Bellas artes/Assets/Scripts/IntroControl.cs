using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour
{
    public float introDuration = 10f; // Duración de la animación en segundos

    void Start()
    {
        // Llamar al método para cargar la siguiente escena después de la duración
        Invoke("nivel_1", introDuration);
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene("nivel_1"); 
    }
}
