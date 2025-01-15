using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para cargar nuevas escenas

public class CambiarEscena : MonoBehaviour
{
    public string nombreEscena;  // Nombre de la escena a cargar

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Verificar si el jugador toca el objeto (asegurándose de que el tag del jugador sea "Player")
        if (collider.CompareTag("Player"))
        {
            // Cargar la escena usando el nombre proporcionado
            SceneManager.LoadScene(nombreEscena);
        }
    }
}
