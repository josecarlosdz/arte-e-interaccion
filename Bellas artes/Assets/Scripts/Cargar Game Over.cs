using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para cargar nuevas escenas

public class Villano : MonoBehaviour
{
    public int toquesParaGameOver = 3;  // Número de toques antes de cargar Game Over
    private int contadorDeToques = 0;   // Contador de toques del jugador

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el personaje (tag "Player") tocó al villano
        if (collision.gameObject.CompareTag("Player"))
        {
            contadorDeToques++;  // Aumentar el contador de toques
            Debug.Log("Toques al villano: " + contadorDeToques);

            // Verificar si el jugador tocó al villano 3 veces
            if (contadorDeToques >= toquesParaGameOver)
            {
                // Cargar la escena de Game Over
                SceneManager.LoadScene("game_over");
            }
        }
    }
}
