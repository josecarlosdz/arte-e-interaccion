using UnityEngine;
using UnityEngine.SceneManagement;  

public class Villano : MonoBehaviour
{
    public int toquesParaGameOver = 3;  
    private int contadorDeToques = 0;   

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            contadorDeToques++;  
            Debug.Log("Toques al villano: " + contadorDeToques);

            
            if (contadorDeToques >= toquesParaGameOver)
            {
                
                SceneManager.LoadScene("game_over");
            }
        }
    }
}
