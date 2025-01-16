using UnityEngine;
using UnityEngine.SceneManagement;  

public class CambiarEscena : MonoBehaviour
{
    public string nombreEscena;  

    void OnTriggerEnter2D(Collider2D collider)
    {
        
        if (collider.CompareTag("Player"))
        {
           
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
